using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("getStatusCartaoPostagem", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class GetStatusCartaoPostagemRequest : BaseRequest<GetStatusCartaoPostagemRequest>
    {
        public GetStatusCartaoPostagemRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "numeroCartaoPostagem")]
        public string NumeroCartaoPostagem { get; set; }

    }
}
