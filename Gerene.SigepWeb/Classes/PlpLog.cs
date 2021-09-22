using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class PlpLog : DFeDocument<PlpLog>
    {
        [DFeElement(TipoCampo.Str, "id_plp", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 1)]
        public string IdPlp { get; set; }

        [DFeElement(TipoCampo.Str, "valor_global", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 2)]
        public string ValorGlobal { get; set; }

        [DFeElement(TipoCampo.Str, "mcu_unidade_postagem", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 3)]
        public string McuUnidadePostagem { get; set; }

        [DFeElement(TipoCampo.Str, "nome_unidade_postagem", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 4)]
        public string NomeUnidadePostagem { get; set; }

        [DFeElement(TipoCampo.Str, "cartao_postagem", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 5)]
        public string CartaoPostagem { get; set; }

        public PlpLog()
        {
            IdPlp = string.Empty;
            ValorGlobal = string.Empty;
            McuUnidadePostagem = string.Empty;
            NomeUnidadePostagem = string.Empty;
            CartaoPostagem = string.Empty;
        }
    } 
}
