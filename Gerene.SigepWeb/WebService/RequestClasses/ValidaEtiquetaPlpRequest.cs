using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("validaEtiquetaPLP", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ValidaEtiquetaPlpRequest : BaseRequest<ValidaEtiquetaPlpRequest>
    {
        public ValidaEtiquetaPlpRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "numeroEtiqueta")]
        public string NumeroEtiqueta { get; set; }

        [DFeElement(TipoCampo.Long, "idPlp")]
        public long IdPlp { get; set; }

    }
}
