using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("pesquisarEmbalagensPorServico", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class PesquisarEmbalagensPorServicoRequest : DFeDocument<PesquisarEmbalagensPorServicoRequest>
    {
        [DFeElement(TipoCampo.Str, "codigo")]
        public string Codigo { get; set; }
    }
}
