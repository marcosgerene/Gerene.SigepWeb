using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class MensagemParametrizadaTo : DFeDocument<MensagemParametrizadaTo>
    {
        [DFeElement(TipoCampo.Str, "mensagem")]
        public string Mensagem { get; set; }

        [DFeElement(TipoCampo.Enum, "tipo")]
        public TipoMensagem Tipo { get; set; }

        [DFeElement(TipoCampo.Str, "titulo")]
        public string Titulo { get; set; }
       
    }

}
