using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ClienteErp : DFeDocument<ClienteErp>
    {

        [DFeElement(TipoCampo.Str, "cnpj")]
        public string Cnpj { get; set; }

        [DFeCollection("contratos")]
        public List<ContratoErp> Contratos { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataAtualizacao")]
        public DateTimeOffset DataAtualizacao { get; set; }

        [DFeElement(TipoCampo.Int, "datajAtualizacao")]
        public int DataJAtualizacao { get; set; }

        [DFeElement(TipoCampo.Str, "descricaoStatusCliente")]
        public string DescricaoStatusCliente { get; set; }

        [DFeElement("gerenteConta")]
        public GerenteConta GerenteConta { get; set; }

        [DFeElement(TipoCampo.Long, "horajAtualizacao")]
        public long HorajAtualizacao { get; set; }

        [DFeElement(TipoCampo.Long, "id")]
        public long Id { get; set; }

        [DFeElement(TipoCampo.Str, "inscricaoEstadual")]
        public string InscricaoEstadual { get; set; }

        [DFeElement(TipoCampo.Str, "nome")]
        public string Nome { get; set; }

        [DFeElement(TipoCampo.Str, "statusCodigo")]
        public string StatusCodigo { get; set; }

    }
}
