using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class Objeto : DFeDocument<Objeto>
    {
        [DFeElement(TipoCampo.Str, "desc")]
        public string Desc { get; set; }

        [DFeElement(TipoCampo.Str, "entrega")]
        public string Entrega { get; set; }

        [DFeElement(TipoCampo.Str, "id")]
        public string Id { get; set; }

        [DFeElement(TipoCampo.Str, "item")]
        public string Item { get; set; }

        [DFeElement(TipoCampo.Str, "num")]
        public string Num { get; set; }
    }
}
