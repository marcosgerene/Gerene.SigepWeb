using ACBr.Net.DFe.Core.Attributes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("atualizaPagamentoNaEntrega", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class AtualizaPagamentoNaEntregaRequest : BaseRequest<AtualizaPagamentoNaEntregaRequest>
    {
        public AtualizaPagamentoNaEntregaRequest(Client client) : base(client)
        {
        }

    }
}
