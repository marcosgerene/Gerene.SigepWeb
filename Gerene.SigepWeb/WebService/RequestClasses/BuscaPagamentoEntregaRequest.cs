using System;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;


namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("buscaPagamentoEntrega", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaPagamentoEntregaRequest : BaseRequest<BuscaPagamentoEntregaRequest>
    {
        public BuscaPagamentoEntregaRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "contrato")]
        public string Contrato { get; set; }

        [DFeElement(TipoCampo.Dat, "dataInicio")]
        public DateTime DataInicio { get; set; }

        [DFeElement(TipoCampo.Dat, "dataFim")]
        public DateTime DataFim { get; set; }

        [DFeElement(TipoCampo.Str, "etiqueta")]
        public string Etiqueta { get; set; }
    }
}
