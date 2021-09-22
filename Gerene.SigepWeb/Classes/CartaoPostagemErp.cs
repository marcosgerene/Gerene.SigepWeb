using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class CartaoPostagemErp : DFeDocument<CartaoPostagemErp>
    {
        [DFeElement(TipoCampo.Str, "codigoAdministrativo")]
        public string CodigoAdministrativo { get; set; }

        [DFeCollection("contratos")]
        public List<ContratoErp> Contratos { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataAtualizacao")]
        public DateTimeOffset DataAtualizacao { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataVigenciaFim")]
        public DateTimeOffset DataVigenciaFim { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataVigenciaInicio")]
        public DateTimeOffset DataVigenciaInicio { get; set; }

        [DFeElement(TipoCampo.Int, "datajAtualizacao")]
        public int DataJAtualizacao { get; set; }

        [DFeElement(TipoCampo.Int, "datajVigenciaFim")]
        public int DataJVigenciaFim { get; set; }

        [DFeElement(TipoCampo.Int, "datajVigenciaInicio")]
        public int DataJVigenciaInicio { get; set; }

        [DFeElement(TipoCampo.Str, "descricaoStatusCartao")]
        public string DescricaoStatusCartao { get; set; }

        [DFeElement(TipoCampo.Str, "descricaoUnidadePostagemGenerica")]
        public string DescricaoUnidadePostagemGenerica { get; set; }

        [DFeElement(TipoCampo.Int, "horajAtualizacao")]
        public int HorajAtualizacao { get; set; }

        [DFeElement(TipoCampo.Str, "numero")]
        public string Numero { get; set; }

        [DFeCollection("servicos")]
        public List<ServicoErp> Servicos { get; set; }

        [DFeElement(TipoCampo.Str, "statusCartaoPostagem")]
        public string StatusCartaoPostagem { get; set; }

        [DFeElement(TipoCampo.Str, "statusCodigo")]
        public string StatusCodigo { get; set; }

        [DFeElement(TipoCampo.Str, "unidadeGenerica")]
        public string UnidadeGenerica { get; set; }

        [DFeElement("unidadesPostagem")]
        public UnidadePostagemErp UnidadesPostagem { get; set; }
    }
}
