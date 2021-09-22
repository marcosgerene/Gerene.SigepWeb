using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class SqlException : DFeDocument<SqlException>
    {
        [DFeElement(TipoCampo.Int, "errorCode")]
        public int ErrorCode { get; set; }

        [DFeElement(TipoCampo.Str, "sQLState")]
        public string SqlState { get; set; }

        [DFeElement(TipoCampo.Str, "message")]
        public string Message { get; set; }

        [DFeElement(TipoCampo.Str, "SigepClienteException")]
        public string SigepClienteException { get; set; }

        [DFeElement(TipoCampo.Str, "AutenticacaoException")]
        public string AutenticacaoException { get; set; }

        [DFeElement("Exception")]
        public Exception Exception { get; set; }
    }
}
