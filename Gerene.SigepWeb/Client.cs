using Gerene.SigepWeb.Classes;
using Gerene.SigepWeb.WebService;


using System;
using System.Collections.Generic;
using System.Text;

using OpenAC.Net.DFe.Core.Extensions;
using OpenAC.Net.Core.Extensions;
using System.IO;
using OpenAC.Net.DFe.Core.Document;
using Gerene.SigepWeb.WebService.RequestClasses;
using Gerene.SigepWeb.WebService.ResponseClasses;

namespace Gerene.SigepWeb
{
    public class Client : IDisposable
    {
        public enum MetodoWebService
        {
            BuscaServicos
        }

        #region Atributos
        public TipoAmbiente Ambiente { get; set; } = TipoAmbiente.Producao;
        public int Timeout { get; set; } = 30000;
        public string PathXmls { get; set; }
        public bool SalvarXmls { get; set; } = true;

        public string XmlEnvio { get; private set; }
        public string XmlResposta { get; private set; }

        public string Usuario { get; set; }
        public string Senha { get; set; }
        #endregion

        #region Construtor
        public Client()
        {
        }

        public void Dispose()
        {
        }
        #endregion

        #region Métodos

        public string BuscaServicos(BuscaServicosRequest request)
        {
            Executar("buscaServicos", request);

            var response = BuscaServicosResponse.Load(XmlResposta);

            return response.ServicoErp;
        }

        public List<ServicoAdicionalXml> BuscaServicosAdicionaisAtivos(BuscaServicosAdicionaisAtivosRequest request)
        {
            Executar("buscaServicosAdicionaisAtivos", request);

            var response = BuscaServicosAdicionaisAtivosResponse.Load(XmlResposta);

            return response.Result;
        }

        public long FechaPlp(FechaPlpRequest request)
        {
            Executar("fechaPlp", request);

            var response = FechaPlpResponse.Load(XmlResposta);

            return response.Result;
        }

        public string CalculaTarifaServico(CalculaTarifaServicoRequest request)
        {
            Executar("calculaTarifaServico", request);

            var response = CalculaTarifaServicoResponse.Load(XmlResposta);

            return response.Result;
        }

        public decimal ValidaPlp(ValidaPlpRequest request)
        {
            Executar("validaPlp", request);

            var response = ValidaPlpResponse.Load(XmlResposta);

            return response.Result;
        }

        public long VerificaSeTodosObjetosCancelados(VerificaSeTodosObjetosCanceladosRequest request)
        {
            Executar("VerificaSeTodosObjetosCancelados", request);

            var response = VerificaSeTodosObjetosCanceladosResponse.Load(XmlResposta);

            return response.Result;
        }

        public decimal CancelarObjeto(CancelarObjetoRequest request)
        {
            Executar("cancelarObjeto", request);

            var response = CancelarObjetoResponse.Load(XmlResposta);

            return response.Result;
        }

        public DimensaoTo PesquisarParametrosPorDescricao(PesquisarParametrosPorDescricaoRequest request)
        {
            Executar("pesquisarParametrosPorDescricao", request);

            var response = PesquisarParametrosPorDescricaoResponse.Load(XmlResposta);

            return response.Result;
        }

        public string AtualizaPagamentoNaEntrega(AtualizaPagamentoNaEntregaRequest request)
        {
            Executar("atualizaPagamentoNaEntrega", request);

            var response = AtualizaPagamentoNaEntregaResponse.Load(XmlResposta);

            return response.Result;
        }

        public string ObterClienteAtualizacao(ObterClienteAtualizacaoRequest request)
        {
            Executar("obterClienteAtualizacao", request);

            var response = ObterClienteAtualizacaoResponse.Load(XmlResposta);

            return response.Result;
        }

        public string VerificaDisponibilidadeServico(VerificaDisponibilidadeServicoRequest request)
        {
            Executar("verificaDisponibilidadeServico", request);

            var response = VerificaDisponibilidadeServicoResponse.Load(XmlResposta);

            return response.Result;
        }

        public long FechaPlpVariosServicos(FechaPlpVariosServicosRequest request)
        {
            Executar("fechaPlpVariosServicos", request);

            var response = FechaPlpVariosServicosResponse.Load(XmlResposta);

            return response.Result;
        }

        public int GeraDigitoVerificadorEtiquetas(GeraDigitoVerificadorEtiquetasRequest request)
        {
            Executar("geraDigitoVerificadorEtiquetas", request);

            var response = GeraDigitoVerificadorEtiquetasResponse.Load(XmlResposta);

            return response.Result;
        }

        public EmbalagemLrsMaster ObterEmbalagemLrs(ObterEmbalagemLrsRequest request)
        {
            Executar("obterEmbalagemLRS", request);

            var response = ObterEmbalagemLrsResponse.Load(XmlResposta);

            return response.Result;
        }

        public long ValidaEtiquetaPlp(ValidaEtiquetaPlpRequest request)
        {
            Executar("validaEtiquetaPlp", request);

            var response = ValidaEtiquetaPlpResponse.Load(XmlResposta);

            return response.Result;
        }

        public string BuscaServicosValorDeclarado(BuscaServicosValorDeclaradoRequest request)
        {
            Executar("buscaServicosValorDeclarado", request);

            var response = BuscaServicosValorDeclaradoResponse.Load(XmlResposta);

            return response.Result;
        }

        public EnderecoErp ConsultaCep(ConsultaCepRequest request)
        {
            Executar("consultaCEP", request);

            var response = ConsultaCepResponse.Load(XmlResposta);

            return response.Result;
        }

        public decimal IntegrarUsuarioScol(IntegrarUsuarioScolRequest request)
        {
            Executar("IntegrarUsuarioScol", request);

            var response = IntegrarUsuarioScolResponse.Load(XmlResposta);

            return response.Result;
        }

        public List<DimensaoTo> PesquisarDimensoesServico(PesquisarDimensoesServicoRequest request)
        {
            Executar("pesquisarDimensoesServico", request);

            var response = PesquisarDimensoesServicoResponse.Load(XmlResposta);

            return response.Result;
        }

        public TipoEmbalagem PesquisarEmbalagensPorServico(PesquisarEmbalagensPorServicoRequest request)
        {
            Executar("pesquisarEmbalagensPorServico", request);

            var response = PesquisarEmbalagensPorServicoResponse.Load(XmlResposta);

            return response.Result;
        }

        public string AtualizaRemessaAgrupada(AtualizaRemessaAgrupadaRequest request)
        {
            Executar("atualizaRemessaAgrupada", request);

            var response = AtualizaRemessaAgrupadaResponse.Load(XmlResposta);

            return response.Result;
        }

        public string SolicitaPlp(SolicitaPlpRequest request)
        {
            Executar("solicitaPlp", request);

            var response = SolicitaPlpResponse.Load(XmlResposta);

            return response.Result;
        }

        public StatusCartao GetStatusCartaoPostagem(GetStatusCartaoPostagemRequest request)
        {
            Executar("getStatusCartaoPostagem", request);

            var response = GetStatusCartaoPostagemResponse.Load(XmlResposta);

            return response.Result;
        }

        public string VerificaModalTransporte(VerificaModalTransporteRequest request)
        {
            Executar("verificaModalTransporte", request);

            var response = VerificaModalTransporteResponse.Load(XmlResposta);

            return response.Result;
        }

        public DateTimeOffset BuscaDataAtual(BuscaDataAtualRequest request)
        {
            Executar("buscaDataAtual", request);

            var response = BuscaDataAtualResponse.Load(XmlResposta);

            return response.Result;
        }

        public List<ValePostal> BuscaTarifaVale(BuscaTarifaValeRequest request)
        {
            Executar("buscaTarifaVale", request);

            var response = BuscaTarifaValeResponse.Load(XmlResposta);

            return response.Result;
        }

        public decimal ValidarPostagemSimultanea(ValidarPostagemSimultaneaRequest request)
        {
            Executar("validarPostagemSimultanea", request);

            var response = ValidarPostagemSimultaneaResponse.Load(XmlResposta);

            return response.Result;
        }

        public StatusPlp GetStatusPlp(GetStatusPlpRequest request)
        {
            Executar("getStatusPlp", request);

            var response = GetStatusPlpResponse.Load(XmlResposta);

            return response.Result;
        }

        public List<ServicoAdicionalTo> PesquisarServicosAdicionais(PesquisarServicosAdicionaisRequest request)
        {
            Executar("pesquisarServicosAdicionais", request);

            var response = PesquisarServicosAdicionaisResponse.Load(XmlResposta);

            return response.Result;
        }

        public string BuscaServicosXServicosAdicionais(BuscaServicosXServicosAdicionaisRequest request)
        {
            Executar("buscaServicosXServicosAdicionais", request);

            var response = BuscaServicosXServicosAdicionaisResponse.Load(XmlResposta);

            return response.Result;
        }

        public List<RetornoCancelamento> CancelarPedidoScol(CancelarPedidoScolRequest request)
        {
            Executar("cancelarPedidoScol", request);

            var response = CancelarPedidoScolResponse.Load(XmlResposta);

            return response.Result;
        }

        public string BloquearObjeto(BloquearObjetoRequest request)
        {
            Executar("bloquearObjeto", request);

            var response = BloquearObjetoResponse.Load(XmlResposta);

            return response.Result;
        }

        public ContratoErp BuscaContrato(BuscaContratoRequest request)
        {
            Executar("buscaContrato", request);

            var response = BuscaContratoResponse.Load(XmlResposta);

            return response.Result;
        }

        public string SolicitaEtiquetas(SolicitaEtiquetasRequest request)
        {
            Executar("solicitaEtiquetas", request);

            var response = SolicitaEtiquetasResponse.Load(XmlResposta);

            return response.Result;
        }

        public string SolicitaXmlPlp(SolicitaXmlPlpRequest request)
        {
            Executar("solicitaXmlPlp", request);

            var response = SolicitaXmlPlpResponse.Load(XmlResposta);

            return response.Result;
        }

        public decimal ValidarPostagemReversa(ValidarPostagemReversaRequest request)
        {
            Executar("validarPostagemReversa", request);

            var response = ValidarPostagemReversaResponse.Load(XmlResposta);

            return response.Result;
        }

        public ClienteErp BuscaCliente(BuscaClienteRequest request)
        {
            Executar("buscaCliente", request);

            var response = BuscaClienteResponse.Load(XmlResposta);

            return response.Result;
        }

        public string BuscaPagamentoEntrega(BuscaPagamentoEntregaRequest request)
        {
            Executar("buscaPagamentoEntrega", request);

            var response = BuscaPagamentoEntregaResponse.Load(XmlResposta);

            return response.Result;
        }

        public string SolicitarPostagemScol(SolicitarPostagemScolRequest request)
        {
            Executar("solicitarPostagemScol", request);

            var response = SolicitarPostagemScolResponse.Load(XmlResposta);

            return response.Result;
        }

        public string ObterMensagemParametrizada(ObterMensagemParametrizadaRequest request)
        {
            Executar("obterMensagemParametrizada", request);

            var response = ObterMensagemParametrizadaResponse.Load(XmlResposta);

            return response.MensagemParametrizadaTo;
        }

        public string BuscaOpcoes(BuscaOpcoesRequest request)
        {
            Executar("buscaOpcoes", request);

            var response = BuscaOpcoesResponse.Load(XmlResposta);

            return response.Result;
        }

        private void Executar<TDocument>(string metodo, BaseRequest<TDocument> request) where TDocument : class =>
            Executar(metodo, (DFeDocument<TDocument>)request);

        private void Executar<TDocument>(string metodo, DFeDocument<TDocument> request) where TDocument : class
        {
            var saveOptions = OpenAC.Net.DFe.Core.Common.DFeSaveOptions.DisableFormatting | OpenAC.Net.DFe.Core.Common.DFeSaveOptions.OmitDeclaration | OpenAC.Net.DFe.Core.Common.DFeSaveOptions.RemoveSpaces;
            string xml = request.GetXml(saveOptions).ToString();

            XmlEnvio = xml;
            XmlResposta = string.Empty;

            var _timeout = TimeSpan.FromMilliseconds(Timeout);

            using (var client = new RequestServiceClient(Ambiente, _timeout))
            {
                try
                {
                    XmlResposta = client.Execute(metodo, xml);
                    XmlEnvio = client.XmlEnvio;
                }
                finally
                {
                    XmlEnvio = client.XmlEnvio;

                    if (SalvarXmls)
                    {
                        string path = Path.Combine(PathXmls, $"{metodo}Request_{DateTime.Now:yyyy-MM-dd_HHmmss}.xml");
                        File.WriteAllText(path, XmlEnvio);

                        path = Path.Combine(PathXmls, $"{metodo}Response_{DateTime.Now:yyyy-MM-dd_HHmmss}.xml");
                        File.WriteAllText(path, XmlResposta);
                    }
                }
            }
        }
        #endregion
    }
}
