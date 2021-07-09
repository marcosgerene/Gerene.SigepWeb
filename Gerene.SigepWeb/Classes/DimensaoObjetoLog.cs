using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.SigepWeb.Classes
{
    public sealed class DimensaoObjetoLog : DFeDocument<DimensaoObjetoLog>
    {
        [DFeElement(TipoCampo.Str, "tipo_objeto", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 1)]
        public string TipoObjeto { get; set; }

        [DFeElement(TipoCampo.Str, "dimensao_altura", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 2)]
        public string Altura { get; set; }

        [DFeElement(TipoCampo.Str, "dimensao_largura", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 3)]
        public string Largura { get; set; }

        [DFeElement(TipoCampo.Str, "dimensao_comprimento", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 4)]
        public string Comprimento { get; set; }

        [DFeElement(TipoCampo.Str, "dimensao_diametro", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 5)]
        public string Diametro { get; set; }
    }
}
