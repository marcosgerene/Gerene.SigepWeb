using System.Collections.Generic;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

using Gerene.SigepWeb.Classes;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    [DFeRoot("VerificaSeTodosObjetosCancelados", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class VerificaSeTodosObjetosCanceladosRequest : DFeDocument<VerificaSeTodosObjetosCanceladosRequest>
    {
        [DFeCollection("arg0")]
        public List<ObjetoPostal> Arg0 { get; set; }
    }
}
