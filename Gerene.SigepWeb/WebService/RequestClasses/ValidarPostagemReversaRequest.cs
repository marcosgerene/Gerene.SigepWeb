using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("validarPostagemReversa", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ValidarPostagemReversaRequest : BaseRequest<ValidarPostagemReversaRequest>
    {
        public ValidarPostagemReversaRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "codAdministrativo")]
        public string CodAdministrativo { get; set; }

        [DFeElement(TipoCampo.Str, "codigoServico")]
        public string CodigoServico { get; set; }

        [DFeElement(TipoCampo.Str, "cepDestinatario")]
        public string CepDestinatario { get; set; }

        [DFeElement(TipoCampo.Str, "idCartaoPostagem")]
        public string IdCartaoPostagem { get; set; }

        [DFeElement("coleta")]
        public ColetaReversa Coleta { get; set; }

    }
}
