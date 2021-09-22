using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class MedidaTo : DFeDocument<MedidaTo>
    {
        [DFeElement(TipoCampo.De10, "maximo")]
        public decimal Maximo { get; set; }

        [DFeElement(TipoCampo.De10, "minimo")]
        public decimal Minimo { get; set; }
    }
}
