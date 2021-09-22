using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("buscaServicos", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaServicosRequest : BaseRequest<BuscaServicosRequest>
    {
        public BuscaServicosRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "idContrato", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 1)]
        public string IdContrato { get; set; }

        [DFeElement(TipoCampo.Str, "idCartaoPostagem", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 2)]
        public string IdCartaoPostagem { get; set; }
    }
}
