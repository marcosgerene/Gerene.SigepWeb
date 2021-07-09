using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class Pessoa : DFeDocument<Pessoa>
    {
        [DFeElement(TipoCampo.Str, "nome")]
        public string Nome { get; set; }

        [DFeElement(TipoCampo.Str, "email")]
        public string Email { get; set; }

        [DFeElement(TipoCampo.Str, "telefone")]
        public string Telefone { get; set; }

        [DFeElement(TipoCampo.Str, "ddd")]
        public string Ddd { get; set; }

        [DFeElement(TipoCampo.Str, "logradouro")]
        public string Logradouro { get; set; }

        [DFeElement(TipoCampo.Str, "bairro")]
        public string Bairro { get; set; }

        [DFeElement(TipoCampo.Str, "numero")]
        public string Numero { get; set; }

        [DFeElement(TipoCampo.Str, "complemento")]
        public string Complemento { get; set; }

        [DFeElement(TipoCampo.Str, "referencia")]
        public string Referencia { get; set; }

        [DFeElement(TipoCampo.Str, "cidade")]
        public string Cidade { get; set; }

        [DFeElement(TipoCampo.Str, "uf")]
        public string Uf { get; set; }

        [DFeElement(TipoCampo.Str, "cep")]
        public string Cep { get; set; }

    }
}
