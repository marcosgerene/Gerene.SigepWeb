using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("buscaDataAtualResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class BuscaDataAtualResponse : DFeDocument<BuscaDataAtualResponse>
    {
        [DFeElement(TipoCampo.DatHorTz, "return")]
        public DateTimeOffset Result { get; set; }
    }
}
