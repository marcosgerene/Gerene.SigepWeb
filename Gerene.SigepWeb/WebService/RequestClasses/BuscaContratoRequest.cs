using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("buscaContrato", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaContratoRequest : BaseRequest<BuscaContratoRequest>
    {
        public BuscaContratoRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "numero")]
        public string Numero { get; set; }

        [DFeElement(TipoCampo.Long, "diretoria")]
        public long Diretoria { get; set; }

    }
}
