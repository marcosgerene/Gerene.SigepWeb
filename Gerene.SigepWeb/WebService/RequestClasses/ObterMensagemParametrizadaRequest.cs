using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("obterMensagemParametrizada", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ObterMensagemParametrizadaRequest : DFeDocument<ObterMensagemParametrizadaRequest>
    {
        [DFeElement(TipoCampo.Str, "id")]
        public string Id { get; set; }

    }
}
