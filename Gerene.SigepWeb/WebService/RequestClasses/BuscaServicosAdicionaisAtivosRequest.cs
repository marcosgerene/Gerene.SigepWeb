using OpenAC.Net.DFe.Core.Attributes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("buscaServicosAdicionaisAtivos", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaServicosAdicionaisAtivosRequest : BaseRequest<BuscaServicosAdicionaisAtivosRequest>
    {
        public BuscaServicosAdicionaisAtivosRequest(Client client) : base(client)
        {
        }
    }
}
