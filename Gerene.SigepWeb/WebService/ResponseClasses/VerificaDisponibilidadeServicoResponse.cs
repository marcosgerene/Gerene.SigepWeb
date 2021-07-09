using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("verificaDisponibilidadeServicoResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class VerificaDisponibilidadeServicoResponse : DFeDocument<VerificaDisponibilidadeServicoResponse>
    {
        [DFeElement(TipoCampo.Str, "return")]
        public string Result { get; set; }
    }
}
