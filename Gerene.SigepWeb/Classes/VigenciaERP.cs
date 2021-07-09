using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class VigenciaErp : DFeDocument<VigenciaErp>
    {
        [DFeElement(TipoCampo.DatHorTz, "dataFinal")]
        public DateTimeOffset DataFinal { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataInicial")]
        public DateTimeOffset DataInicial { get; set; }
       
        [DFeElement(TipoCampo.Int, "datajFim")]
        public int DataJFim { get; set; }

        [DFeElement(TipoCampo.Int, "dataJIni")]
        public int DataJIni { get; set; }

        [DFeElement(TipoCampo.Long, "id")]
        public long Id { get; set; }       
    }
}
