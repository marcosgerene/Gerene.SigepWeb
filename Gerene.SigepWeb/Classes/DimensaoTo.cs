using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;

namespace Gerene.SigepWeb.Classes
{
    public sealed class DimensaoTo : DFeDocument<DimensaoTo>
    {
        [DFeElement("altura")]
        public MedidaTo Altura { get; set; }

        [DFeElement( "comprimento")]
        public MedidaTo Comprimento { get; set; }

        [DFeElement("diametro")]
        public MedidaTo Diametro { get; set; }

        [DFeElement( "largura")]
        public MedidaTo Largura { get; set; }

        [DFeElement( "peso")]
        public MedidaTo Peso { get; set; }

        [DFeElement("soma")]
        public MedidaTo Soma { get; set; }
    }
}
