using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

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
