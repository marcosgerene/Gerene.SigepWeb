using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ObjetoPostal : DFeDocument<ObjetoPostal>
    {
        [DFeElement(TipoCampo.Str, "codigoEtiqueta")]
        public string CodigoEtiqueta { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataAtualizacaoCliente")]
        public DateTimeOffset DataAtualizacaoCliente { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataBloqueioObjeto")]
        public DateTimeOffset DataBloqueioObjeto { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataCancelamentoEtiqueta")]
        public DateTimeOffset DataCancelamentoEtiqueta { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataInclusao")]
        public DateTimeOffset DataInclusao { get; set; }

        [DFeElement("objetoPostalPK")]
        public ObjetoPostalPk ObjetoPostalPk { get; set; }

        [DFeElement(TipoCampo.Long, "plpNu")]
        public long PlpNu { get; set; }

        [DFeElement("preListaPostagem")]
        public PreListaPostagem PreListaPostagem { get; set; }

        [DFeElement(TipoCampo.Enum, "restricaoAerea")]
        public SimNao RestricaoAerea { get; set; }

        [DFeElement(TipoCampo.Str, "statusBloqueio")]
        public string StatusBloqueio { get; set; }

        [DFeElement(TipoCampo.Enum, "statusEtiqueta")]
        public StatusObjetoPostal StatusEtiqueta { get; set; }

    }
}
