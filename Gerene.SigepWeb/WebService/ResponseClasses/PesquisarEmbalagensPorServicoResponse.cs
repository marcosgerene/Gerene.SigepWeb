using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("pesquisarEmbalagensPorServicoResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class PesquisarEmbalagensPorServicoResponse : DFeDocument<PesquisarEmbalagensPorServicoResponse>
    {
        [DFeElement(TipoCampo.Enum, "return")]
        public TipoEmbalagem Result { get; set; }
    }
}
