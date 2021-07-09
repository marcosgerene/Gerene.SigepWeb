using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("consultaCEP", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ConsultaCepRequest : DFeDocument<ConsultaCepRequest>
    {

        [DFeElement(TipoCampo.Str, "cep")]
        public string Cep { get; set; }

    }
}
