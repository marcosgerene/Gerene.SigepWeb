using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ObjetoPostalPk : DFeDocument<ObjetoPostalPk>
    {
        [DFeElement(TipoCampo.Str, "codigoEtiqueta")]
        public string CodigoEtiqueta { get; set; }

        [DFeElement(TipoCampo.Long, "plpNu")]
        public long PlpNu { get; set; }
    }
}
