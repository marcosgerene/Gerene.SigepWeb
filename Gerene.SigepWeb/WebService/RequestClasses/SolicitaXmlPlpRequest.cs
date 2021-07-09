using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("solicitaXmlPlp", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class SolicitaXmlPlpRequest : BaseRequest<SolicitaXmlPlpRequest>
    {
        public SolicitaXmlPlpRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Long, "idPlpMaster")]
        public long IdPlpMaster { get; set; }

    }
}
