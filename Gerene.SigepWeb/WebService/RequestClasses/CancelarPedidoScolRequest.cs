using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("cancelarPedidoScol", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class CancelarPedidoScolRequest : BaseRequest<CancelarPedidoScolRequest>
    {
        public CancelarPedidoScolRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "codAdministrativo")]
        public string CodAdministrativo { get; set; }

        [DFeElement(TipoCampo.Str, "idPostagem")]
        public string IdPostagem { get; set; }

        [DFeElement(TipoCampo.Str, "tipo")]
        public string Tipo { get; set; }
    }
}
