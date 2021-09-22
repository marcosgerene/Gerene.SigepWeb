using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ParametroMaster : DFeDocument<ParametroMaster>
    {
        [DFeElement(TipoCampo.Long, "prmCoParametro")]
        public long PrmCoParametro { get; set; }

        [DFeElement(TipoCampo.Str, "prmTxParametro")]
        public string PrmTxParametro { get; set; }

        [DFeElement(TipoCampo.Str, "prmTxValor")]
        public string PrmTxValor { get; set; }
    }
}
