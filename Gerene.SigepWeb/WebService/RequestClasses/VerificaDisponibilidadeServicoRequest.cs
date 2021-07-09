using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("verificaDisponibilidadeServico", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class VerificaDisponibilidadeServicoRequest : BaseRequest<VerificaDisponibilidadeServicoRequest>
    {
        public VerificaDisponibilidadeServicoRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Int, "codAdministrativo")]
        public string CodAdministrativo { get; set; }

        [DFeElement(TipoCampo.Str, "numeroServico")]
        public string NumeroServico { get; set; }

        [DFeElement(TipoCampo.Str, "cepOrigem")]
        public string CepOrigem { get; set; }

        [DFeElement(TipoCampo.Str, "cepDestino")]
        public string CepDestino { get; set; }

    }
}
