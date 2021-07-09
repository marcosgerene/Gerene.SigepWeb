using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("cancelarObjetoResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class CancelarObjetoResponse : DFeDocument<CancelarObjetoResponse>
    {
        [DFeElement(TipoCampo.De10, "return")]
        public decimal Result { get; set; }
    }
}
