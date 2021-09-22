using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("buscaDataAtual", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaDataAtualRequest : DFeDocument<BuscaDataAtualRequest>
    {
       
    }
}
