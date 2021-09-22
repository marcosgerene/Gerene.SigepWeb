using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.SigepWeb.Classes
{
    public sealed class RemetenteLog : DFeDocument<RemetenteLog>
    {
        [DFeElement(TipoCampo.Str, "numero_contrato", Ocorrencia = Ocorrencia.Obrigatoria, Ordem =1)]
        public string NumeroContrato { get; set; }

        [DFeElement(TipoCampo.Str, "numero_diretoria", Ocorrencia = Ocorrencia.Obrigatoria, Ordem =2)]
        public string NumeroDiretoria { get; set; }

        [DFeElement(TipoCampo.Str, "codigo_administrativo", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 3)]
        public string CodigoAdministrativo { get; set; }

        [DFeElement(TipoCampo.Str, "nome_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 4)]
        public string Nome { get; set; }

        [DFeElement(TipoCampo.Str, "logradouro_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 5)]
        public string Logradouro { get; set; }

        [DFeElement(TipoCampo.Str, "numero_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 6)]
        public string Numero { get; set; }

        [DFeElement(TipoCampo.Str, "complemento_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 7)]
        public string Complemento { get; set; }

        [DFeElement(TipoCampo.Str, "bairro_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 8)]
        public string Bairro { get; set; }

        [DFeElement(TipoCampo.Str, "cep_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 9)]
        public string Cep { get; set; }

        [DFeElement(TipoCampo.Str, "cidade_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 10)]
        public string Cidade { get; set; }

        [DFeElement(TipoCampo.Str, "uf_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 11)]
        public string Uf { get; set; }

        [DFeElement(TipoCampo.Str, "telefone_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 12)]
        public string Telefone { get; set; }

        [DFeElement(TipoCampo.Str, "fax_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 13)]
        public string Fax { get; set; }

        [DFeElement(TipoCampo.Str, "email_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 14)]
        public string Email { get; set; }

        [DFeElement(TipoCampo.Str, "celular_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 15)]
        public string Celular { get; set; }

        [DFeElement(TipoCampo.Str, "cpf_cnpj_remetente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 16)]
        public string CpfCnpj { get; set; }

        [DFeElement(TipoCampo.Str, "ciencia_conteudo_proibido", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 17)]
        public string CienciaConteudoProibido { get; set; }

    }
}
