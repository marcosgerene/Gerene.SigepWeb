using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Common;
using ACBr.Net.DFe.Core.Serializer;
using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("solicitarPostagemScol", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class SolicitarPostagemScolRequest : BaseRequest<SolicitarPostagemScolRequest>
    {
        public SolicitarPostagemScolRequest(Client client) : base(client)
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
                    ListaPlps = CorreiosLog.Load(value);
            }
        }

        [DFeElement(TipoCampo.Int, "codAdministrativo")]
        public int CodAdministrativo { get; set; }

    }
}
