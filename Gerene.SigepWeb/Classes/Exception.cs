using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class Exception : DFeDocument<Exception>
    {
        [DFeElement(TipoCampo.Str, "message")]
        public string Message { get; set; }

        [DFeElement("ErroMontagemRelatorio")]
        public ErroMontagemRelatorio ErroMontagemRelatorio { get; set; }
    }
}
