using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("fechaPlpVariosServicosResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class FechaPlpVariosServicosResponse : DFeDocument<FechaPlpVariosServicosResponse>
    {
        [DFeElement(TipoCampo.Long, "return")]
        public long Result { get; set; }
    }
}
