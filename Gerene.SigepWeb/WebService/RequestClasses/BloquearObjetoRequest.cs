using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("bloquearObjeto", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BloquearObjetoRequest : BaseRequest<BloquearObjetoRequest>
    {
        public BloquearObjetoRequest(Client client) : base(client)
        {
        }

        [DFeElement(TipoCampo.Str, "numeroEtiqueta")]
        public string NumeroEtiqueta { get; set; }

        [DFeElement(TipoCampo.Str, "idPlp")]
        public string IdPlp { get; set; }

        [DFeElement(TipoCampo.Enum, "tipoBloqueio")]
        public TipoBloqueio TipoBloqueio { get; set; }

        [DFeElement(TipoCampo.Enum, "acao")]
        public Acao Acao { get; set; }

    }
}
