using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ObjetoSimplificado : DFeDocument<ObjetoSimplificado>
    {
        [DFeElement(TipoCampo.Str, "datahora_cancelamento")]
        public string DatahoraCancelamento { get; set; }

        [DFeElement(TipoCampo.Int, "numero_pedido")]
        public int NumeroPedido { get; set; }

        [DFeElement(TipoCampo.Str, "status_pedido")]
        public string StatusPedido { get; set; }
    }
}
