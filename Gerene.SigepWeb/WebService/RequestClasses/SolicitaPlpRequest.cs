using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("solicitaPLP", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class SolicitaPlpRequest : BaseRequest<SolicitaPlpRequest>
    {
        public SolicitaPlpRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Long, "idPlpMaster")]
        public long IdPlpMaster { get; set; }

        [DFeElement(TipoCampo.Str, "numEtiqueta")]
        public string NumEtiqueta { get; set; }

    }
}
