using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class PreListaPostagem : DFeDocument<PreListaPostagem>
    {

        [DFeElement("cartaoPostagem")]
        public CartaoPostagemErp CartaoPostagem { get; set; }

        [DFeElement(TipoCampo.Enum, "conteudoProibido")]
        public SimNao ConteudoProibido { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataAtualizacaoCliente")]
        public DateTimeOffset DataAtualizacaoCliente { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataAtualizacaoSara")]
        public DateTimeOffset DataAtualizacaoSara { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataFechamento")]
        public DateTimeOffset DataFechamento { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataPostagem")]
        public DateTimeOffset DataPostagem { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataPostagemSara")]
        public DateTimeOffset DataPostagemSara { get; set; }

        [DFeElement("objetosPostais")]
        public ObjetoPostal ObjetosPostais { get; set; }

        [DFeElement(TipoCampo.Long, "plpCliente")]
        public long PlpCliente { get; set; }

        [DFeElement(TipoCampo.Long, "plpNu")]
        public long PlpNu { get; set; }

        [DFeElement(TipoCampo.Long, "plpXml")]
        public long PlpXml { get; set; }

        [DFeElement(TipoCampo.Long, "plpXmlRetorno")]
        public long PlpXmlRetorno { get; set; }

        [DFeElement(TipoCampo.Enum, "status")]
        public StatusPlp Status { get; set; }
    }
}
