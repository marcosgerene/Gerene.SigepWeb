using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("validaPlpResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ValidaPlpResponse : DFeDocument<ValidaPlpResponse>
    {
        [DFeElement(TipoCampo.De10, "return")]
        public decimal Result { get; set; }
    }
}
