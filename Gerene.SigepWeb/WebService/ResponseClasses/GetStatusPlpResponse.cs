using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("getStatusPLPResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class GetStatusPlpResponse : DFeDocument<GetStatusPlpResponse>
    {
        [DFeElement(TipoCampo.Enum,"statusPlp")]
        public StatusPlp Result { get; set; }
    }
}
