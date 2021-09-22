using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class Coleta : DFeDocument<Coleta>
    {
        [DFeElement(TipoCampo.Str, "cklist")]
        public string Cklist { get; set; }

        [DFeElement(TipoCampo.Str, "descricao")]
        public string Descricao { get; set; }

        [DFeElement(TipoCampo.Str, "documento")]
        public string Documento { get; set; }

        [DFeElement(TipoCampo.Str, "id_cliente")]
        public string IdCliente { get; set; }

        [DFeCollection("produto")]
        public List<Produto> Produto { get; set; }

        [DFeElement("remetente")]
        public Remetente Remetente { get; set; }

        [DFeElement(TipoCampo.Str, "tipo")]
        public string Tipo{ get; set; }

        [DFeElement(TipoCampo.Str, "valor_declarado")]
        public string ValorDeclarado { get; set; }
    }
}
