using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("cancelarObjeto", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class CancelarObjetoRequest : BaseRequest<CancelarObjetoRequest>
    {
        public CancelarObjetoRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Long, "idPlp")]
        public long IdPlp { get; set; }

        [DFeElement(TipoCampo.Str, "numeroEtiqueta")]
        public string NumeroEtiqueta { get; set; }

    } 
}
