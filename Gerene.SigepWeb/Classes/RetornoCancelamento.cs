using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class RetornoCancelamento : DFeDocument<RetornoCancelamento>
    {
        [DFeElement(TipoCampo.Str, "cod_erro")]
        public string CodErro { get; set; }

        [DFeElement(TipoCampo.Str, "codigo_administrativo")]
        public string CodigoAdministrativo { get; set; }

        [DFeElement(TipoCampo.Str, "data")]
        public string Data { get; set; }

        [DFeElement(TipoCampo.Str, "hora")]
        public string Hora { get; set; }

        [DFeElement(TipoCampo.Str, "msg_erro")]
        public string MsgErro { get; set; }

        [DFeElement("objeto_postal")]
        public ObjetoSimplificado ObjetoPostal { get; set; }
    }
}
