using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ServicoSigep : DFeDocument<ServicoSigep>
    {
        [DFeElement(TipoCampo.Enum, "categoriaServico")]
        public CategoriaServico CategoriaServico { get; set; }

        [DFeElement("chancela")]
        public ChancelaMaster Chancela { get; set; }

        [DFeElement(TipoCampo.Str, "descricao")]
        public string Descricao { get; set; }

        [DFeElement(TipoCampo.Str, "exigeDimensoes")]
        internal string ExigeDimensoesProxy
        {
            get => ExigeDimensoes ? "true" : "false";
            set
            {
                if (value == "true")
                    ExigeDimensoes = true;
                else if (value == "false")
                    ExigeDimensoes = false;
                else
                    throw new ArgumentException($"Valor para \"exigeDimensoes\" é inválido \"{value}\"");
            }
        }

        [DFeIgnore]
        public bool ExigeDimensoes { get; set; }

        [DFeElement(TipoCampo.Str, "exigeValorCobrar")]
        internal string ExigeValorCobrarProxy
        {
            get => ExigeValorCobrar ? "true" : "false";
            set
            {
                if (value == "true")
                    ExigeValorCobrar = true;
                else if (value == "false")
                    ExigeValorCobrar = false;
                else
                    throw new ArgumentException($"Valor para \"exigeValorCobrar\" é inválido \"{value}\"");
            }
        }

        [DFeIgnore]
        public bool ExigeValorCobrar { get; set; }

        [DFeElement(TipoCampo.Long, "imitm")]
        public long Imitm { get; set; }

        [DFeElement(TipoCampo.Str, "pagamentoEntrega")]
        public string PagamentoEntrega { get; set; }

        [DFeElement(TipoCampo.Str, "remessaAgrupada")]
        public string RemessaAgrupada { get; set; }

        [DFeElement(TipoCampo.Enum, "restricao")]
        public SimNao Restricao { get; set; }

        [DFeElement(TipoCampo.Long, "servico")]
        public long Servico { get; set; }

        [DFeElement("servicoERP")]
        public ServicoErp ServicoErp { get; set; }

        [DFeElement(TipoCampo.Str, "ssiCoCodigoPostal")]
        public string SsiCoCodigoPostal { get; set; }
    }
}
