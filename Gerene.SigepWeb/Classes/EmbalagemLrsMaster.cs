using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

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
