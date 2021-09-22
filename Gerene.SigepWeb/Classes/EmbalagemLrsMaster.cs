using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class EmbalagemLrsMaster : DFeDocument<EmbalagemLrsMaster>
    {
        [DFeElement(TipoCampo.Str, "codigo")]
        public string Codigo { get; set; }

        [DFeElement(TipoCampo.Str, "nome")]
        public string Nome { get; set; }

        [DFeElement(TipoCampo.Str, "tipo")]
        public string Tipo { get; set; }
    }
}
