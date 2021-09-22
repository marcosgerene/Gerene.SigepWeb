using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.SigepWeb.Classes
{
    [DFeRoot("correioslog")]
    public sealed class CorreiosLog : DFeDocument<CorreiosLog>
    {
        [DFeElement(TipoCampo.Str, "tipo_arquivo", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 1)]
        public string TipoArquivo { get; set; }

        [DFeElement(TipoCampo.Str, "versao_arquivo", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 2)]
        public string VersaoArquivo { get; set; }

        [DFeElement("plp", Ordem = 3)]
        public PlpLog Plp { get; set; }

        [DFeElement("remetente", Ordem = 4)]
        public RemetenteLog Remetente { get; set; }

        [DFeElement(TipoCampo.Str, "forma_pagamento", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 5)]
        public string FormaPagamento { get; set; }

        [DFeCollection("objeto_postal", Ordem = 6)]
        public List<ObjetoPostalLog> ObjetoPostalLog { get; set; }
    }
}
