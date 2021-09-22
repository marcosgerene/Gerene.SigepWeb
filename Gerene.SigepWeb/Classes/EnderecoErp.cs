using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class EnderecoErp : DFeDocument<EnderecoErp>
    {
        [DFeElement(TipoCampo.Str, "bairro")]
        public string Bairro { get; set; }

        [DFeElement(TipoCampo.Str, "cep")]
        public string Cep { get; set; }

        [DFeElement(TipoCampo.Str, "cidade")]
        public string Cidade { get; set; }

        [DFeElement(TipoCampo.Str, "complemento2")]
        public string Complemento2 { get; set; }

        [DFeElement(TipoCampo.Str, "end")]
        public string End { get; set; }

        [DFeElement(TipoCampo.Str, "uf")]
        public string Uf { get; set; }

        [DFeElement("unidadesPostagem")]
        public UnidadePostagemErp UnidadesPostagem { get; set; }
    }
}
