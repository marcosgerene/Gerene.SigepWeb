﻿using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ColetaSimultanea : DFeDocument<ColetaSimultanea>
    {
        public ColetaSimultanea()
        {
        }

        [DFeElement(TipoCampo.Str, "obj")]
        public string Obj { get; set; }

        [DFeElement(TipoCampo.Str, "obs")]
        public string Obs { get; set; }
    }
}
