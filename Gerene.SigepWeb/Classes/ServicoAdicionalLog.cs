using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ServicoAdicionalLog : DFeDocument<ServicoAdicionalLog>
    {
        [DFeElement(TipoCampo.Str, "valor_declarado", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 1)]
        public string ValorDeclarado { get; set; }

        [DFeElement(TipoCampo.Str, "codigo_servico_adicional", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 2)]
        public string CodigoServicoAdicional { get; set; }

        [DFeElement(TipoCampo.Str, "endereco_vizinho", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 3)]
        public string EnderecoVizinho { get; set; }
    }
}
