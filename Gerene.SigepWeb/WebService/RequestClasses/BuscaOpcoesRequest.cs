using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("buscaOpcoes", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaOpcoesRequest : BaseRequest<BuscaOpcoesRequest>
    {
        public BuscaOpcoesRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "listaObjetos")]
        public string ListaObjetos { get; set; }

        [DFeElement(TipoCampo.Str, "tipoResultado")]
        public string TipoResultado { get; set; }

    }
}
