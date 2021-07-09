using System;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using ACBr.Net.Core;
using ACBr.Net.Core.Extensions;
using ACBr.Net.DFe.Core;

namespace Gerene.SigepWeb.WebService
{
    public enum TipoAmbiente
    {
        Producao,
        Homologacao
    }

    internal sealed class RequestServiceClient : ClientBase<IRequestChannel>
    {
        const string xmlns = @"http://cliente.bean.master.sigep.bsb.correios.com.br/";
        const string urlHomologacao = @"https://apphom.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl";
        const string urlProducao = @"https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente?wsdl";

        #region Campos
        public TipoAmbiente Ambiente { get; private set; }

        private readonly object serviceLock;
        public string XmlEnvio { get; set; }

        #endregion 

        #region Construtores

        public RequestServiceClient(TipoAmbiente ambiente, TimeSpan? TimeOut = null) : base(new BasicHttpsBinding(), new EndpointAddress(UrlAmbiente(ambiente)))
        {
            serviceLock = new object();

            Ambiente = ambiente;

            if (!TimeOut.HasValue) return;

            Endpoint.Binding.OpenTimeout = TimeOut.Value;
            Endpoint.Binding.ReceiveTimeout = TimeOut.Value;
            Endpoint.Binding.SendTimeout = TimeOut.Value;

            (Endpoint.Binding as BasicHttpsBinding).MaxReceivedMessageSize = int.MaxValue; //alguns métodos como buscarServios tem retornos muito grande
        }

        private static string UrlAmbiente(TipoAmbiente ambiente)
        {
            switch (ambiente)
            {
                case TipoAmbiente.Homologacao: return urlHomologacao;
                case TipoAmbiente.Producao: return urlProducao;
                default: throw new NotImplementedException();
            }
        }

        #endregion Constructors

        #region Metodos

        /// <summary>
        /// Executa uma requisição ao webservice.
        /// </summary>
        /// <param name="action"></param>
        /// <param name="msg"></param>
        /// <param name="headers"></param>
        /// <returns></returns>
        public string Execute(string action, string msg, params MessageHeader[] headers)
        {
            lock (serviceLock)
            {
                var xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(msg);

                //Sigep não permite declação do xmlns, é neessário usar Prefixo
                xmlDoc.FirstChild.Prefix = $"cli";
                msg = xmlDoc.InnerXml.Replace($"xmlns=\"{xmlns}\"", string.Empty);

                xmlDoc.LoadXml(msg);

                var message = Message.CreateMessage(Endpoint.Binding.MessageVersion, action, xmlDoc.DocumentElement);
                message.Headers.Clear(); //Sigep exige heaader vazio

                XmlEnvio = message.ToString();

                var ret = Channel.Request(message);
                Guard.Against<ACBrDFeException>(ret == null, "Nenhum retorno do webservice.");
                var reader = ret.GetReaderAtBodyContents();

                string soapResponse = reader.ReadOuterXml();
               
                var xmlDocument = XDocument.Parse(soapResponse);
                var retorno = TratarRetorno(xmlDocument);
                if (IsValidXml(retorno))
                    return retorno;

                throw new ApplicationException(retorno);
            }
        }

        private static bool IsValidXml(string xmlstring)
        {
            try
            {
                var xDocument = XDocument.Parse(xmlstring);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Baseado em Gerene.Gnre WebServiceClient
        private string TratarRetorno(XDocument xmlDocument)
        {
            var element = xmlDocument.ElementAnyNs("Fault");
            if (element != null)
            {
                var exMessage = $"{element.ElementAnyNs("faultcode")?.GetValue<string>()} - " +
                                $"{element.ElementAnyNs("faultstring")?.GetValue<string>()}";
                throw new ACBrDFeCommunicationException(exMessage);
            }

            return xmlDocument.ToXmlDocument().OuterXml;
        }

        #endregion Methods
    }
}
