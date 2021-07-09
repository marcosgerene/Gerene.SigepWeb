using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("solicitaEtiquetas", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class SolicitaEtiquetasRequest : BaseRequest<SolicitaEtiquetasRequest>
    {
        public SolicitaEtiquetasRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "tipoDestinatario")]
        public string TipoDestinatario { get; set; }

        [DFeElement(TipoCampo.Str, "identificador")]
        public string Identificador { get; set; }

        [DFeElement(TipoCampo.Long, "idServico")]
        public long IdServico { get; set; }

        [DFeElement(TipoCampo.Int, "qtdEtiquetas")]
        public int QtdEtiquetas { get; set; }

    }
}
