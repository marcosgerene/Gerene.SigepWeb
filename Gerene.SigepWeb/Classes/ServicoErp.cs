using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;


namespace Gerene.SigepWeb.Classes
{
    public sealed class ServicoErp : DFeDocument<ServicoErp>
    {
        [DFeElement(TipoCampo.Str, "codigo")]
        public string Codigo { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataAtualizacao")]
        public DateTimeOffset DataAtualizacao { get; set; }

        [DFeElement(TipoCampo.Int, "datajAtualizacao")]
        public int DataJAtualizacao { get; set; }

        [DFeElement(TipoCampo.Str, "descricao")]
        public string Descricao { get; set; }

        [DFeElement(TipoCampo.Int, "horajAtualizacao")]
        public int HorajAtualizacao { get; set; }

        [DFeElement(TipoCampo.Long, "id")]
        public long Id { get; set; }
        
        [DFeElement("servicoSigep")]
        public ServicoSigep ServicosSigep { get; set; }

        [DFeCollection("servicosAdicionais")]
        public List<ServicoAdicionalErp> ServicosAdicionais { get; set; }

        [DFeElement(TipoCampo.Str, "tipo1Codigo")]
        public string Tipo1Codigo { get; set; }
        
        [DFeElement(TipoCampo.Str, "tipo1Descricao")]
        public string Tipo1Descricao { get; set; }

        [DFeElement(TipoCampo.Str, "tipo2Codigo")] 
        public string Tipo2Codigo { get; set; }

        [DFeElement(TipoCampo.Str, "tipo2Descricao")] 
        public string Tipo2Descricao { get; set; }

        [DFeElement("vigencia")] 
        public VigenciaErp Vigencia { get; set; }
    }
}
