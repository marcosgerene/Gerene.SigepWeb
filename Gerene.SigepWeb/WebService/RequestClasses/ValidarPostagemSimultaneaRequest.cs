using System.Collections.Generic;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("validarPostagemSimultanea", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ValidarPostagemSimultaneaRequest : BaseRequest<ValidarPostagemSimultaneaRequest>
    {
        public ValidarPostagemSimultaneaRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Int, "codAdministrativo")]
        public int CodAdministrativo { get; set; }

        [DFeElement(TipoCampo.Int, "codigoServico")]
        public int CodigoServico { get; set; }

        [DFeElement(TipoCampo.Str, "idCartaoPostagem")]
        public string IdCartaoPostagem { get; set; }

        [DFeElement(TipoCampo.Str, "cepDestinatario")]
        public string CepDestinatario { get; set; }

        [DFeElement("coleta")]
        public ColetaSimultanea Coleta{ get; set; }

    }
}
