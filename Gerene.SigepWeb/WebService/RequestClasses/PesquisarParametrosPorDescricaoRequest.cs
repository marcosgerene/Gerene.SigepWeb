using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("pesquisarParametrosPorDescricao", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class PesquisarParametrosPorDescricaoRequest : DFeDocument<PesquisarParametrosPorDescricaoRequest>
    {
        [DFeElement(TipoCampo.Str, "prefix")]
        public string Prefix { get; set; }
    }
}
