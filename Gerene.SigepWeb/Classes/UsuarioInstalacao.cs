using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class UsuarioInstalacao : DFeDocument<UsuarioInstalacao>
    {
        [DFeElement(TipoCampo.DatHorTz, "dataAtualizacao")]
        public DateTimeOffset DataAtualizacao { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataInclusao")]
        public DateTimeOffset DataInclusao { get; set; }

        [DFeElement(TipoCampo.Dat, "dataSenha")]
        public DateTime DataSenha { get; set; }

        [DFeElement("gerenteMaster")]
        public GerenteConta GerenteMaster { get; set; }

        [DFeElement(TipoCampo.Str, "hashSenha")]
        public string HashSenha { get; set; }

        [DFeElement(TipoCampo.Long, "id")]
        public long Id { get; set; }

        [DFeElement(TipoCampo.Str, "login")]
        public string Login { get; set; }

        [DFeElement(TipoCampo.Str, "nome")]
        public string Nome { get; set; }

        [DFeElement("parametros")]
        public ParametroMaster Parametros { get; set; }

        [DFeElement(TipoCampo.Str, "senha")]
        public string Senha { get; set; }

        [DFeElement(TipoCampo.Enum, "status")]
        public StatusUsuario Status { get; set; }

        [DFeElement(TipoCampo.Str, "validade")]
        public string Validade { get; set; }
    }
}
