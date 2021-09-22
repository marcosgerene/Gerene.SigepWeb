using OpenAC.Net.DFe.Core.Attributes;
using OpenAC.Net.DFe.Core.Document;
using OpenAC.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.WebService.RequestClasses
{
    public abstract class BaseRequest<TDocument> : DFeDocument<TDocument> where TDocument : class
    {
        [DFeElement(TipoCampo.Str, "usuario", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = int.MaxValue - 1)]
        public string Usuario { get; set; }

        [DFeElement(TipoCampo.Str, "senha", Ocorrencia = Ocorrencia.NaoObrigatoria, Ordem = int.MaxValue)]
        public string Senha { get; set; }

        public BaseRequest(Client client)
        {
            Usuario = client.Usuario;
            Senha = client.Senha;
        }
    }
}
