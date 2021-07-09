using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("obterClienteAtualizacao", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ObterClienteAtualizacaoRequest : BaseRequest<ObterClienteAtualizacaoRequest>
    {
        public ObterClienteAtualizacaoRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "cnpjCliente")]
        public string CnpjCliente { get; set; }

    }
}
