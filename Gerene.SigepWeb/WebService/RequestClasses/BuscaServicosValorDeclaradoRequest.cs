using ACBr.Net.DFe.Core.Attributes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("buscaServicosValorDeclarado", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaServicosValorDeclaradoRequest : BaseRequest<BuscaServicosValorDeclaradoRequest>
    {
        public BuscaServicosValorDeclaradoRequest(Client client) : base(client)
        {
        }

    }
}
