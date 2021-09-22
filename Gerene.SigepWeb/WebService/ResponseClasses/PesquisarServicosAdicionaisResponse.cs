using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;

using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("pesquisarServicosAdicionaisResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class PesquisarServicosAdicionaisResponse : DFeDocument<PesquisarServicosAdicionaisResponse>
    {
        [DFeCollection("return")]
        public List<ServicoAdicionalTo> Result { get; set; }
    }
}
