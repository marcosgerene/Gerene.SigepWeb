using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Common;
using OpenAC.Net.DFe.Core.Serializer;
using Gerene.SigepWeb.Classes;
using System.Collections.Generic;

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

        [DFeElement(TipoCampo.Str, "xml", UseCData = true)]
        public string XmlPlp
        {
            get => $"<?xml version=\"1.0\" encoding=\"ISO-8859-1\" ?>{ListaPlps.GetXml(DFeSaveOptions.OmitDeclaration | DFeSaveOptions.DisableFormatting | DFeSaveOptions.RemoveSpaces)}";
            set
            {
                if (string.IsNullOrEmpty(value))
                    ListaPlps = null;

                else
                {
                    if (value.StartsWith(@"<?xml"))
                        value = value.Substring(value.IndexOf("<correioslog"));

                    ListaPlps = CorreiosLog.Load(value);
                }
            }
        }

        [DFeElement(TipoCampo.Str, "idPlpCliente")]
        public string IdPlpCliente { get; set; }

        [DFeElement(TipoCampo.Str, "cartaoPostagem")]
        public string CartaoPostagem { get; set; }

        [DFeCollection(TipoCampo.Str, "listaEtiquetas")]
        public List<string> ListaEtiquetas { get; set; }

    }
}
