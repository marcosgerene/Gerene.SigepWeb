using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ChancelaMaster : DFeDocument<ChancelaMaster>
    {
        [DFeElement(TipoCampo.Enum, "ativo")]
        public SimNao Ativo { get; set; }

        [DFeElement(TipoCampo.De10, "chancela")]
        public decimal Chancela  {get; set;}

        [DFeElement(TipoCampo.DatHorTz, "dataAtualizacao")]
        public DateTimeOffset DataAtualizacao { get; set; }

        [DFeElement(TipoCampo.Str, "descricao")]
        public string Descricao { get; set; }

        [DFeElement(TipoCampo.Long, "id")]
        public long Id { get; set; }

        [DFeElement("servicoSigep")]
        public ServicoSigep ServicosSigep { get; set; }
    }
}
