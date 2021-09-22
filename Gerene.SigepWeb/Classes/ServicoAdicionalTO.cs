using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ServicoAdicionalTo : DFeDocument<ServicoAdicionalTo>
    {
        [DFeElement(TipoCampo.Str, "categoria")]
        public string Categoria { get; set; }

        [DFeElement(TipoCampo.Str, "codigo")]
        public string Codigo { get; set; }

        [DFeElement(TipoCampo.Str, "sigla")]
        public string Sigla { get; set; }

        [DFeElement(TipoCampo.Str, "tipo")]
        public string Tipo { get; set; }
    }
}
