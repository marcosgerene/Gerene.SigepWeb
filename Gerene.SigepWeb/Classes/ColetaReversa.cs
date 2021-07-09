using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ColetaReversa : DFeDocument<ColetaReversa>
    {
        public ColetaReversa()
        {
        } 

        [DFeElement(TipoCampo.Str, "ag")]
        public string Ag { get; set; }

        [DFeElement(TipoCampo.Int, "ar")]
        public int Ar { get; set; }

        [DFeElement(TipoCampo.Str, "cartao")]
        public string Cartao { get; set; }

        [DFeElement(TipoCampo.Int, "numero")]
        public int Numero { get; set; }

        [DFeCollection("obj_col")]
        public List<Objeto> ObjCol { get; set; }

        [DFeElement(TipoCampo.Str, "servico_adicional")]
        public string ServicoAdicional { get; set; }
    }
}
