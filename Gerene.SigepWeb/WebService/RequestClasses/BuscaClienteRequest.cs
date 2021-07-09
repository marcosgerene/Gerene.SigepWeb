using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("buscaCliente", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaClienteRequest : BaseRequest<BuscaClienteRequest>
    {
        public BuscaClienteRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "idContrato")]
        public string IdContrato { get; set; }

        [DFeElement(TipoCampo.Str, "idCartaoPostagem")]
        public string IdCartaoPostagem { get; set; }
       
    }
}
