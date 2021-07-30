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

        [DFeElement(TipoCampo.Int, "dimensao_altura", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 2)]
        public int Altura { get; set; }

        [DFeElement(TipoCampo.Int, "dimensao_largura", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 3)]
        public int Largura { get; set; }

        [DFeElement(TipoCampo.Int, "dimensao_comprimento", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 4)]
        public int Comprimento { get; set; }

        [DFeElement(TipoCampo.Int, "dimensao_diametro", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 5)]
        public int Diametro { get; set; }
    }
}
