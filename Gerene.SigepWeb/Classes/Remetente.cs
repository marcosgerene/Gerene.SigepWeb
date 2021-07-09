using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class Remetente : DFeDocument<Remetente>
    {
        public Remetente(Pessoa pessoa)
        {
        }

        [DFeElement(TipoCampo.Long, "celular")]
        public long Celular { get; set; }

        [DFeElement(TipoCampo.Str, "codigo")]
        public string DddCelular { get; set; }

        [DFeElement(TipoCampo.Str, "nome")]
        public string Identificacao { get; set; }

        [DFeElement(TipoCampo.Str, "tipo")]
        public string Sms { get; set; }
    }
}
