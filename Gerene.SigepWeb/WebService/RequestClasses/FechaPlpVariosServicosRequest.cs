using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;
using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("fechaPlpVariosServicos", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class FechaPlpVariosServicosRequest : BaseRequest<FechaPlpVariosServicosRequest>
    {
        public FechaPlpVariosServicosRequest(Client client) : base(client)
        {
        }
        
        [DFeIgnore]        
        public CorreiosLog ListaPlps { get; set; }

        /// <summary>
        /// Xml dos PLPs que serão enviados, formatado em CData. Será serializado o objeto ListaPlps
        /// </summary>
        [DFeElement(TipoCampo.Str, "xml", UseCData = true)]
        public string XmlPlp 
        {
            get => ListaPlps.GetXml();
            set
            {
                if (string.IsNullOrEmpty(value))
                    ListaPlps = null;

                else
                    ListaPlps = CorreiosLog.Load(value);
            }
        }

        [DFeElement(TipoCampo.Int, "idPlpCliente")]
        public string IdPlpCliente { get; set; }

        [DFeElement(TipoCampo.Str, "cartaoPostagem")]
        public string CartaoPostagem { get; set; }

        [DFeElement(TipoCampo.Str, "listaEtiquetas")]
        public string ListaEtiquetas { get; set; }

    }
}
