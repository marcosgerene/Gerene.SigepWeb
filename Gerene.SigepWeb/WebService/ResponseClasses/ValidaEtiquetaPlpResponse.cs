﻿using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("validaEtiquetaPLPResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ValidaEtiquetaPlpResponse : DFeDocument<ValidaEtiquetaPlpResponse>
    {
        [DFeElement(TipoCampo.Long, "return")]
        public long Result { get; set; }
    }
}
