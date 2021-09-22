using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ServicoAdicionalErp : DFeDocument<ServicoAdicionalErp>
    {
        [DFeElement(TipoCampo.Str, "categoria")]
        public string Categoria { get; set; }

        [DFeElement(TipoCampo.Str, "codigo")]
        public string Codigo { get; set; }

        [DFeElement(TipoCampo.Dat, "dataAtualizacao")]
        public DateTime DataAtualizacao { get; set; }

        [DFeElement(TipoCampo.Int, "datajAtualizacao")]
        public int DataJAtualizacao { get; set; }

        [DFeElement(TipoCampo.Str, "descricao")]
        public string Descricao { get; set; }

        [DFeElement(TipoCampo.Int, "horajAtualizacao")]
        public int HorajAtualizacao { get; set; }

        [DFeElement(TipoCampo.Int, "id")]
        public int Id { get; set; }

        [DFeElement(TipoCampo.Str, "sigla")]
        public string Sigla { get; set; }

        [DFeElement("valorDeclarado")]
        public ValorDeclarado ValorDeclarado { get; set; }
    }
}
