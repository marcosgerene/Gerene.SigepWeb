using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ContratoErp : DFeDocument<ContratoErp>
    {
        [DFeElement("cartoesPostagem")]
        public CartaoPostagemErp CartoesPostagem { get; set; }

        [DFeElement("cliente")]
        public ClienteErp Cliente { get; set; }

        [DFeElement(TipoCampo.Long, "codigoCliente")]
        public long CodigoCliente { get; set; }

        [DFeElement(TipoCampo.Str, "codigoDiretoria")]
        public string CodigoDiretoria { get; set; }

        [DFeElement("contratoPK")]
        public ContratoErppk ContratoPk { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataAtualizacao")]
        public DateTimeOffset DataAtualizacao { get; set; }

        [DFeElement(TipoCampo.Str, "dataAtualizacaoDDMMYYYY")]
        public string DataAtualizacaoDdMmYyyy { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataVigenciaFim")]
        public DateTimeOffset DataVigenciaFim { get; set; }

        [DFeElement(TipoCampo.Str, "datajVigenciaFimDDMMYYYY")]
        public string DataJVigenciaFimDdMmYyyy { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataVigenciaInicio")]
        public DateTimeOffset DataVigenciaInicio { get; set; }

        [DFeElement(TipoCampo.Str, "datajVigenciaInicioDDMMYYYY")]
        public string DataJVigenciaInicioDdMmYyyy { get; set; }

        [DFeElement(TipoCampo.Int, "dataJAtualizacao")]
        public int DataJAtualizacao { get; set; }

        [DFeElement(TipoCampo.Int, "datajVigenciaFim")]
        public int DataJVigenciaFim { get; set; }

        [DFeElement(TipoCampo.Int, "datajVigenciaInicio")]
        public int DataJVigenciaInicio { get; set; }

        [DFeElement(TipoCampo.Str, "descricaoDiretoriaRegional")]
        public string DescricaoDiretoriaRegional { get; set; }

        [DFeElement(TipoCampo.Str, "descricaoStatus")]
        public string DescricaoStatus { get; set; }

        [DFeElement("unidadesPostagem")]
        public UnidadePostagemErp UnidadesPostagem { get; set; }

        [DFeElement(TipoCampo.Int, "horaJAtualizacao")]
        public int HoraJAtualizacao { get; set; }

        [DFeElement(TipoCampo.Str, "StatusCodigo")]
        public string StatusCodigo { get; set; }
    }
}
