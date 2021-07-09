using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

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
