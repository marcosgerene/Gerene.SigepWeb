using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("validaPlp", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ValidaPlpRequest : BaseRequest<ValidaPlpRequest>
    {
        public ValidaPlpRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Long, "cliente")]
        public long Cliente { get; set; }

        [DFeElement(TipoCampo.Str, "numero")]
        public string Numero { get; set; }

        [DFeElement(TipoCampo.Long, "diretoria")]
        public long Diretoria { get; set; }

        [DFeElement(TipoCampo.Str, "cartao")]
        public string Cartao { get; set; }

        [DFeElement(TipoCampo.Str, "unidadePostagem")]
        public string UnidadePostagem { get; set; }

        [DFeElement(TipoCampo.Long, "servico")]
        public long Servico { get; set; }

        [DFeElement(TipoCampo.Str, "servicosAdicionais")]
        public string ServicosAdicionais { get; set; }

    }
}
