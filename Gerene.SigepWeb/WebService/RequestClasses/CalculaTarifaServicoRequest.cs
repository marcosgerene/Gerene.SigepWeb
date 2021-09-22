using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("calculaTarifaServico", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class CalculaTarifaServicoRequest : BaseRequest<CalculaTarifaServicoRequest>
    {
        public CalculaTarifaServicoRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "codAdministrativo")]
        public string CodAdministrativo { get; set; }

        [DFeElement(TipoCampo.Str, "codServico")]
        public string CodServico { get; set; }

        [DFeElement(TipoCampo.Str, "cepOrigem")]
        public string CepOrigem { get; set; }

        [DFeElement(TipoCampo.Str, "cepDestino")]
        public string CepDestino { get; set; }

        [DFeElement(TipoCampo.Str, "peso")]
        public string Peso { get; set; }

        [DFeElement(TipoCampo.Int, "codFormato")]
        public int CodFormato { get; set; }

        [DFeElement(TipoCampo.De10, "comprimento")]
        public decimal Comprimento { get; set; }

        [DFeElement(TipoCampo.De10, "altura")]
        public decimal Altura { get; set; }

        [DFeElement(TipoCampo.De10, "largura")]
        public decimal Largura { get; set; }

        [DFeElement(TipoCampo.De10, "diametro")]
        public decimal Diametro { get; set; }

        [DFeElement(TipoCampo.Str, "codMaoPropria")]
        public string CodMaoPropria { get; set; }

        [DFeElement(TipoCampo.De10, "valorDeclarado")]
        public decimal ValorDeclarado { get; set; }

        [DFeElement(TipoCampo.Str, "codAvisoRecebimento")]
        public string CodAvisoRecebimento { get; set; }
    }

}
