using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("pesquisarParametrosPorDescricao", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class PesquisarParametrosPorDescricaoRequest : DFeDocument<PesquisarParametrosPorDescricaoRequest>
    {
        [DFeElement(TipoCampo.Str, "prefix")]
        public string Prefix { get; set; }
    }
}
