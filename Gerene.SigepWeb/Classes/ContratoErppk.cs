using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ContratoErppk: DFeDocument<ContratoErppk>
    {
        [DFeElement(TipoCampo.Long, "diretoria")]
        public long Diretoria { get; set; }

        [DFeElement(TipoCampo.Str, "numero")]
        public string Numero { get; set; }
    }
}
