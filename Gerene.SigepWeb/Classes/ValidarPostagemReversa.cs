using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ValidarPostagemReversa : DFeDocument<ValidarPostagemReversa>
    {
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

        [DFeElement(TipoCampo.Str, "usuario")]
        public string Usuario { get; set; }

        [DFeElement(TipoCampo.Str, "senha")]
        public string Senha { get; set; }
    }
}
