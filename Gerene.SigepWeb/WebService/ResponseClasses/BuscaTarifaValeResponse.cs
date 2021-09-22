using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("buscaTarifaValeResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaTarifaValeResponse : DFeDocument<BuscaTarifaValeResponse>
    {
        [DFeCollection("return")]
        public List<ValePostal> Result { get; set; }
    }
}
