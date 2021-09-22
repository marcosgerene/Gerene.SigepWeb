using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class SolicitaXmlPlp : DFeDocument<SolicitaXmlPlp>
    {
        [DFeElement(TipoCampo.Long, "idPlpMastercodAdministrativo")]
        public long IdPlpMaster { get; set; }

        [DFeElement(TipoCampo.Str, "usuario")]
        public string Usuario { get; set; }

        [DFeElement(TipoCampo.Str, "senha")]
        public string Senha { get; set; }
    }
}
