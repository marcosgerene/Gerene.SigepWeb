using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;

using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("buscaServicosResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/" )]
    public sealed class BuscaServicosResponse : DFeDocument<BuscaServicosResponse>
    {
        [DFeElement("return")]
        public string ServicoErp { get; set; }
    }
}
