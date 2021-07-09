using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("pesquisarDimensoesServico", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class PesquisarDimensoesServicoRequest : DFeDocument<PesquisarDimensoesServicoRequest>
    {
        [DFeElement(TipoCampo.Str, "codigo")]
        public string Codigo { get; set; }

        [DFeElement(TipoCampo.Str, "embalagem")]
        public string Embalagem { get; set; }
    }
}
