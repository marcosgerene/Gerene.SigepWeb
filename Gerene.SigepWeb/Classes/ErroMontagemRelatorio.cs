using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ErroMontagemRelatorio : DFeDocument<ErroMontagemRelatorio>
    {
        [DFeElement(TipoCampo.Str, "message")]
        public string Message { get; set; }
    }
}
