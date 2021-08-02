using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.SigepWeb.Classes
{
    public sealed class NacionalLog : DFeDocument<NacionalLog>
    {
        [DFeElement(TipoCampo.Str, "bairro_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 1)]
        public string Bairro { get; set; }
        
        [DFeElement(TipoCampo.Str, "cidade_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 2)]
        public string Cidade { get; set; }

        [DFeElement(TipoCampo.Str, "uf_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 3)]
        public string Uf { get; set; }

        [DFeElement(TipoCampo.Str, "cep_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 4)]
        public string Cep { get; set; }

        [DFeElement(TipoCampo.Str, "codigo_usuario_postal", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 5)]
        public string CodigoUsuarioPostal { get; set; }

        [DFeElement(TipoCampo.Str, "centro_custo_cliente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 6)]
        public string CentroCustoCliente { get; set; }

        [DFeElement(TipoCampo.Str, "numero_nota_fiscal", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 7)]
        public string NumeroNotaFiscal { get; set; }

        [DFeElement(TipoCampo.Str, "serie_nota_fiscal", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 8)]
        public string SerieNotaFiscal { get; set; }

        [DFeElement(TipoCampo.Str, "valor_nota_fiscal", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 9)]
        public string ValorNotaFiscal { get; set; }

        [DFeElement(TipoCampo.Str, "natureza_nota_fiscal", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 10)]
        public string NaturezaNotaFiscal { get; set; }

        [DFeElement(TipoCampo.Str, "descricao_objeto", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 11)]
        public string DescricaoObjeto { get; set; }

        [DFeElement(TipoCampo.Str, "valor_a_cobrar", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 12)]
        public string ValorACobrar { get; set; }
    }
}
