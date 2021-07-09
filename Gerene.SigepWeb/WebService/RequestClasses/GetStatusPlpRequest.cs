using System.Collections.Generic;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("getStatusPLP", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class GetStatusPlpRequest : BaseRequest<GetStatusPlpRequest>
    {
        public GetStatusPlpRequest(Client client) : base(client)
        {
        }

        [DFeCollection("arg0")]
        public List<ObjetoPostal> Arg0 { get; set; }

        [DFeElement(TipoCampo.Str, "arg1")]
        public string Arg1 { get; set; }

    }
}
