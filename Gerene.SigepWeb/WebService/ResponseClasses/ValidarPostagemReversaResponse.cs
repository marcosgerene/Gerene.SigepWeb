﻿using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.ResponseClasses
{
    [DFeRoot("validarPostagemReversaResponse", Namespace = "http://cliente.bean.master.sigep.bsb.correios.com.br/")]
    public sealed class ValidarPostagemReversaResponse : DFeDocument<ValidarPostagemReversaResponse>
    {
        [DFeElement(TipoCampo.De10, "return")]
        public decimal Result { get; set; }
    }
}
