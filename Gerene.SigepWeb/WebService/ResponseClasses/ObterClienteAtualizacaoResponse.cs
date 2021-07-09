using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("obterClienteAtualizacaoResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ObterClienteAtualizacaoResponse : DFeDocument<ObterClienteAtualizacaoResponse>
    {
        [DFeElement(TipoCampo.Str, "return")]
        public string Result { get; set; }
    }
}
