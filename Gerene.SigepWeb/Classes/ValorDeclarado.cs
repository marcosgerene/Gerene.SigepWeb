using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{ 
    public sealed class ValorDeclarado : DFeDocument<ValorDeclarado>
    {
        [DFeElement(TipoCampo.De10, "maximo")]
        public decimal Maximo { get; set; }

        [DFeElement(TipoCampo.De10, "minimo")]
        public decimal Minimo { get; set; }
    }
}
