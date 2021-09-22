using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class GerenteConta : DFeDocument<GerenteConta>
    {
        [DFeElement("clientesVisiveis")]
        public ClienteErp ClientesVisiveis { get; set; }

        [DFeElement(TipoCampo.DatHorTz, "dataAtualizacao")]
        public DateTimeOffset DataAtualizacao { get; set; }

        [DFeElement(TipoCampo.Dat, "dataInclusao")]
        public DateTime DataInclusao { get; set; }

        [DFeElement(TipoCampo.Dat, "dataSenha")]
        public DateTime DataSenha { get; set; }

        [DFeElement(TipoCampo.Str, "login")]
        public string Login { get; set; }

        [DFeElement(TipoCampo.Str, "matricula")]
        public string Matricula { get; set; }

        [DFeElement(TipoCampo.Str, "senha")]
        public string Senha { get; set; }

        [DFeElement(TipoCampo.Enum, "status")]
        public StatusGerente Status { get; set; }

        [DFeElement(TipoCampo.Enum, "tipoGerente")]
        public TipoGerente TipoGerente { get; set; }

        [DFeElement("usuarioInstalacao")]
        public UsuarioInstalacao UsuarioInstalacao { get; set; }

        [DFeElement(TipoCampo.Str, "validade")]
        public string Validade { get; set; }
    }

}
