using OpenAC.Net.DFe.Core.Attributes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("buscaServicosXServicosAdicionais", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaServicosXServicosAdicionaisRequest : BaseRequest<BuscaServicosXServicosAdicionaisRequest>
    {
        public BuscaServicosXServicosAdicionaisRequest(Client client) : base(client)
        {
        }
    }
}
