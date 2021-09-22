using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ServicoAdicionalLog : DFeDocument<ServicoAdicionalLog>
    {
        [DFeCollection(TipoCampo.Str, "codigo_servico_adicional", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 1)]
        public List<string> CodigoServicoAdicional { get; set; }
     
        [DFeElement(TipoCampo.De2, "valor_declarado", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 2)]
        public decimal ValorDeclarado { get; set; }

        [DFeElement(TipoCampo.Str, "endereco_vizinho", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 3)]
        public string EnderecoVizinho { get; set; }
    }
}
