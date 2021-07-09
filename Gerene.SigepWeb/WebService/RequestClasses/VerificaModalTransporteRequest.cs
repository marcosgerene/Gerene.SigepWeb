using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("verificaModalTransporte", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class VerificaModalTransporteRequest : BaseRequest<VerificaModalTransporteRequest>
    {
        public VerificaModalTransporteRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "codigoServico")]
        public string CodigoServico { get; set; }

        [DFeElement(TipoCampo.Str, "cepOrigem")]
        public string CepOrigem { get; set; }

        [DFeElement(TipoCampo.Str, "cepDestino")]
        public string CepDestino { get; set; }

    }
}
