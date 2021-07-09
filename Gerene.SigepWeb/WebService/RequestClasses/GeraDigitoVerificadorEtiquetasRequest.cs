using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("geraDigitoVerificadorEtiquetas", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class GeraDigitoVerificadorEtiquetasRequest : BaseRequest<GeraDigitoVerificadorEtiquetasRequest>
    {
        public GeraDigitoVerificadorEtiquetasRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "etiquetas")]
        public string Etiquetas { get; set; }

    }
}
