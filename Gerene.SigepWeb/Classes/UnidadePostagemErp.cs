using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class UnidadePostagemErp : DFeDocument<UnidadePostagemErp>
    {
        [DFeElement(TipoCampo.Str, "diretoriaRegional")]
        public string DiretoriaRegional { get; set; }

        [DFeElement("endereco")]
        public EnderecoErp Endereco { get; set; }

        [DFeElement(TipoCampo.Str, "id")]
        public string Id { get; set; }

        [DFeElement(TipoCampo.Str, "nome")]
        public string Nome { get; set; }

        [DFeElement(TipoCampo.Str, "status")]
        public string Status { get; set; }

        [DFeElement(TipoCampo.Str, "tipo")]
        public string Tipo { get; set; }

    }
}
