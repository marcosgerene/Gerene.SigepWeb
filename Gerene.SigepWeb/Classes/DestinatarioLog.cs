using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.SigepWeb.Classes
{
    public sealed class DestinatarioLog : DFeDocument<DestinatarioLog>
    {
        [DFeElement(TipoCampo.Str, "nome_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 1)]
        public string Nome { get; set; }

        [DFeElement(TipoCampo.Str, "telefone_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 2)]
        public string Telefone { get; set; }

        [DFeElement(TipoCampo.Str, "celular_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 3)]
        public string Celular { get; set; }

        [DFeElement(TipoCampo.Str, "email_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 4)]
        public string Email { get; set; }

        [DFeElement(TipoCampo.Str, "logradouro_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 5)]
        public string Logradouro { get; set; }

        [DFeElement(TipoCampo.Str, "complemento_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, UseCData = true, Ordem = 6)]
        public string Complemento { get; set; }

        [DFeElement(TipoCampo.Str, "numero_end_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 7)]
        public string Numero { get; set; }

        [DFeElement(TipoCampo.Str, "cpf_cnpj_destinatario", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 8)]
        public string CpfCnpj { get; set; }
    }
}
