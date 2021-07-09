using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.SigepWeb.Classes
{
    public sealed class PlpLog : DFeDocument<PlpLog>
    {
        [DFeElement(TipoCampo.Str, "id_plp", Ordem = 1)]
        public string IdPlp { get; set; }

        [DFeElement(TipoCampo.Str, "valor_global", Ordem = 2)]
        public string ValorGlobal { get; set; }

        [DFeElement(TipoCampo.Str, "mcu_unidade_postagem", Ordem = 3)]
        public string McuUnidadePostagem { get; set; }

        [DFeElement(TipoCampo.Str, "nome_unidade_postagem", Ordem = 4)]
        public string NomeUnidadePostagem { get; set; }

        [DFeElement(TipoCampo.Str, "cartao_postagem", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 5)]
        public string CartaoPostagem { get; set; } 
        
    } 
}
