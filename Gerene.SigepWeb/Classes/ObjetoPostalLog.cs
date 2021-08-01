using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ObjetoPostalLog : DFeDocument<ObjetoPostalLog>
    {
        [DFeElement(TipoCampo.Str, "numero_etiqueta", Ordem = 1)]
        public string NumeroEtiqueta { get; set; }

        [DFeElement(TipoCampo.Str, "codigo_objeto_cliente", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 2)]
        public string CodigoObjetoCliente { get; set; }

        [DFeElement(TipoCampo.Str, "codigo_servico_postagem", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 3)]
        public string CodigoServicoPostagem { get; set; }

        [DFeElement(TipoCampo.De2, "cubagem", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 4)]
        public decimal? Cubagem { get; set; }

        [DFeElement(TipoCampo.Int, "peso", Min = 5, Max = 5, Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 5)]
        public int Peso { get; set; }

        [DFeElement(TipoCampo.Str, "rt1", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = 6)]
        public string Rt1 { get; set; }

        [DFeElement(TipoCampo.Str, "rt2", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 7)]
        public string Rt2 { get; set; }

        [DFeElement(TipoCampo.Str, "restricao_anac", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 8)]
        public string Restricao_anac { get; set; }

        [DFeElement("destinatario", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 9)]
        public DestinatarioLog Destinatario { get; set; }

        [DFeElement("nacional", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 10)]
        public NacionalLog Nacional { get; set; }

        [DFeElement("servico_adicional", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 11)]
        public ServicoAdicionalLog ServicoAdicional { get; set; }

        [DFeElement("dimensao_objeto", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 12)]
        public DimensaoObjetoLog DimensaoObjeto { get; set; }

        [DFeElement(TipoCampo.Str, "data_postagem_sara", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 13)]
        public string DataPostagemSara { get; set; }

        [DFeElement(TipoCampo.Str, "status_processamento", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 14)]
        public string StatusProcessamento { get; set; }

        [DFeElement(TipoCampo.Str, "numero_comprovante_postagem", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 15)]
        public string NumeroComprovantePostagem { get; set; }

        [DFeElement(TipoCampo.Str, "valor_cobrado", Ocorrencia = Ocorrencia.Obrigatoria, Ordem = 16)]
        public string ValorCobrado { get; set; }
    }
}
