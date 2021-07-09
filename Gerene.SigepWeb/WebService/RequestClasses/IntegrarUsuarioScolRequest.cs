using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("integrarUsuarioScol", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class IntegrarUsuarioScolRequest : BaseRequest<IntegrarUsuarioScolRequest>
    {
        public IntegrarUsuarioScolRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Int, "codAdministrativo")]
        public int CodAdministrativo { get; set; }

    }
}
