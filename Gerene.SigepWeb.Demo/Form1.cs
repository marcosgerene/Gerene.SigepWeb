using Gerene.SigepWeb.Classes;
using Gerene.SigepWeb.WebService;
using Gerene.SigepWeb.WebService.RequestClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerene.SigepWeb.Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboAmbiente.DataSource = Enum.GetValues(typeof(TipoAmbiente));
            ComboAmbiente.SelectedItem = TipoAmbiente.Homologacao;
        }

        private string InputBox(string mensagem, string texto = null)
        {
            using (var form = new InputBox())
            {
                form.Text = mensagem;
                form.TextBox1.Text = texto ?? string.Empty;
                form.ShowDialog();

                return form.Tag != null ? form.Tag.ToString().Trim() : string.Empty;
            }
        }

        private Client GetClient() => new Client()
        {
            Usuario = TextUsuario.Text,
            Senha = TextSenha.Text,

            Ambiente = (TipoAmbiente)ComboAmbiente.SelectedItem,
            SalvarXmls = CheckSalvarXmls.Checked,
            PathXmls = TextPath.Text,
            Timeout = (int)TextTimeout.Value,
        };

        private void BtnBuscarServicos_Click(object sender, EventArgs e)
        {
            string idcontrato = "9992157880";
            string idcartaopostagem = "0067599079";

            idcontrato = InputBox("Id do contrato", idcontrato);
            idcartaopostagem = InputBox("Id do cartão de postagem", idcartaopostagem);

            if (string.IsNullOrEmpty(idcontrato) || string.IsNullOrEmpty(idcartaopostagem))
                return;

            using (var client = GetClient())
            {
                var request = new BuscaServicosRequest(client)
                {
                    IdContrato = idcontrato,
                    IdCartaoPostagem = idcartaopostagem
                };

                //O retorno será a de serviços
                var servicoErp = client.BuscaServicos(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = $"{servicoErp} serviços!"; //client.XmlResposta; O buscarServicos tem um retorno extremamente grandee trava o Demo
            }
        }

        private void BuscaServicosAdicionaisAtivos_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                var request = new BuscaServicosAdicionaisAtivosRequest(client)
                {
                };

                _ = client.BuscaServicosAdicionaisAtivos(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnFechaPlp_Click(object sender, EventArgs e)
        {
            string xml = string.Empty;
            string idplpcliente = string.Empty; // Código gerado pelo cliente para identificação da PLP.
            string cartaopostagem = "0067599079";
            string faixaetiquetas = "SZ99996640 BR,SZ99996640 BR";

            xml = InputBox("Informe o xml da plp", xml);
            idplpcliente = InputBox("Informe o idplp cliente", idplpcliente);
            cartaopostagem = InputBox("Informe o cartão postal", cartaopostagem);
            faixaetiquetas = InputBox("Informe a faixa de etiquetas", faixaetiquetas);

            if (string.IsNullOrEmpty(xml) || string.IsNullOrEmpty(idplpcliente) || string.IsNullOrEmpty(cartaopostagem) || string.IsNullOrEmpty(faixaetiquetas))
                return;

            using (var client = GetClient())
            {
                var request = new FechaPlpRequest(client)
                {
                    XmlPlp = xml,
                    IdPlpCliente = long.Parse(idplpcliente.ToString()),
                    CartaoPostagem = cartaopostagem,
                    FaixaEtiquetas = faixaetiquetas
                };

                _ = client.FechaPlp(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnCalculaTarifaServico_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codadministrativo = InputBox("Informe o codigo administrativo", "17000190");
                string codservico = InputBox("Informe o codigo do serviço", "04162");
                string ceporigem = InputBox("Informe o cep de origem", "05311900");
                string cepdestino = InputBox("Informe o cep de destino", "05311900");
                string peso = InputBox("Informe o peso", "0");
                string codformato = InputBox("Informe o formato", "1");
                string comprimento = InputBox("Informe o comprimento", "0");
                string altura = InputBox("Informe o altura ", "0");
                string largura = InputBox("Informe o largura", "0");
                string diametro = InputBox("Informe o diametro", "0");
                string codmaopropria = InputBox("Informe o codigo da mão propria", "02");
                string valordeclarado = InputBox("Informe o valor declarado", "200");
                string codavisorecebimento = InputBox("Informe o codigo aviso de recebiemento", "1");

                var request = new CalculaTarifaServicoRequest(client)
                {
                    CodAdministrativo = codadministrativo,
                    CodServico = codservico,
                    CepOrigem = ceporigem,
                    CepDestino = cepdestino,
                    Peso = peso,
                    CodFormato = int.Parse(codformato),
                    Comprimento = decimal.Parse(comprimento),
                    Altura = decimal.Parse(altura),
                    Largura = decimal.Parse(largura),
                    Diametro = decimal.Parse(diametro),
                    CodMaoPropria = codmaopropria,
                    ValorDeclarado = decimal.Parse(valordeclarado),
                    CodAvisoRecebimento = codavisorecebimento
                };

                _ = client.CalculaTarifaServico(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnValidaPlp_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string cliente = InputBox("Informe o cliente", "279311"); // O Cliente não está Ativo no Sigep Master 
                string numero = InputBox("Informe o numero", "0733382100116");
                string diretoria = InputBox("Informe o numero da diretoria", "10");
                string cartao = InputBox("Informe o cartao postagem", "01");
                string unidadepostagem = InputBox("Informe a unidade postagem", string.Empty); // É obrigatório o campo ficar vazio, pois será preenchido pelo retorno deste método.
                string servico = InputBox("Informe o numero do serviço", "04162");
                string servicosadicionais = InputBox("Informe o numero do servicos adicionais", "025");

                var request = new ValidaPlpRequest(client)
                {
                    Cliente = long.Parse(cliente),
                    Numero = numero,
                    Diretoria = long.Parse(diretoria),
                    Cartao = cartao,
                    UnidadePostagem = unidadepostagem,
                    Servico = long.Parse(servico),
                    ServicosAdicionais = servicosadicionais
                };

                _ = client.ValidaPlp(request); // Erro 'soap:Server - java.lang.NullPointerException'

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnVerificaSeTodosObjetosCancelados_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codigoetiqueta = InputBox(" Informe o objeto Postal", string.Empty);
                string dataatualizadacliente = InputBox("Informe o objeto de coleta", string.Empty);
                var request = new VerificaSeTodosObjetosCanceladosRequest()
                {
                    //Preencher objeto request
                };

                _ = client.VerificaSeTodosObjetosCancelados(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnCancelarObjeto_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string idplp = string.Empty;
                string numeroetiqueta = "DL746686536BR";

                idplp = InputBox("Informe o idPlp", idplp);
                numeroetiqueta = InputBox("Informe o numero da etiqueta", numeroetiqueta);

                if (string.IsNullOrEmpty(idplp) || string.IsNullOrEmpty(numeroetiqueta))
                    return;

                var request = new CancelarObjetoRequest(client)
                {
                    IdPlp = long.Parse(idplp.ToString()),
                    NumeroEtiqueta = numeroetiqueta
                };

                _ = client.CancelarObjeto(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnPesquisarParametrosPorDescricao_Click(object sender, EventArgs e)
        {
            string prefixo = InputBox("Informe o prefixo", "caixa");

            using (var client = GetClient())
            {
                var request = new PesquisarParametrosPorDescricaoRequest()
                {
                    Prefix = prefixo
                };

                _ = client.PesquisarParametrosPorDescricao(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnAtualizaPagamentoNaEntrega_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                var request = new AtualizaPagamentoNaEntregaRequest(client)
                {
                };

                _ = client.AtualizaPagamentoNaEntrega(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnObterClienteAtualizacao_Click(object sender, EventArgs e)
        {
            string cnpjcliente = "34028316000103";

            cnpjcliente = InputBox("Informe o cnpj do cliente", cnpjcliente);

            if (string.IsNullOrEmpty(cnpjcliente))
                return;

            using (var client = GetClient())
            {
                var request = new ObterClienteAtualizacaoRequest(client)
                {
                    CnpjCliente = cnpjcliente

                };

                _ = client.ObterClienteAtualizacao(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }

        }

        private void BtnVerificaDisponibilidadeServico_Click_1(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codadministrativo = InputBox("Informe o codigo administrativo", "17000190");
                string numeroservico = InputBox("Informe o numero do serviço", "04669");
                string ceporigem = InputBox("Informe o cep de origem", "05311900");
                string cepdestino = InputBox("Informe o cep de destino", "05311900");

                var request = new VerificaDisponibilidadeServicoRequest(client)
                {
                    CodAdministrativo = codadministrativo,
                    NumeroServico = numeroservico,
                    CepOrigem = ceporigem,
                    CepDestino = cepdestino,
                };

                _ = client.VerificaDisponibilidadeServico(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnFechaPlpVariosServicos_Click(object sender, EventArgs e)
        {
            string xml = string.Empty;
            string idplpcliente = string.Empty; // Código gerado pelo cliente para identificação da PLP. 
            string cartaopostagem = "0067599079";
            string listaetiquetas = "SZ99996638BR ";// Lista de objetos enviados via parâmetro sem o dígito verificador.( $listaEtiquetas = array('SO00064196BR', 'SL99922179BR'));

            xml = InputBox("Informe o xml da plp", xml);
            idplpcliente = InputBox("Informe o idplp cliente", idplpcliente);
            cartaopostagem = InputBox("Informe o cartão postal", cartaopostagem);
            listaetiquetas = InputBox("Informe as etiquetas", listaetiquetas);

            if (string.IsNullOrEmpty(xml) || string.IsNullOrEmpty(idplpcliente) || string.IsNullOrEmpty(cartaopostagem) || string.IsNullOrEmpty(listaetiquetas))
                return;

            using (var client = GetClient())
            {
                var request = new FechaPlpVariosServicosRequest(client)
                {
                    XmlPlp = xml,
                    IdPlpCliente = idplpcliente,
                    CartaoPostagem = cartaopostagem,
                    ListaEtiquetas = listaetiquetas
                };

                _ = client.FechaPlpVariosServicos(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnGeraDigitoVerificadorEtiquetas_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string etiquetas = InputBox("Informe o numero da etiqueta", "DL74668653 BR");

                var request = new GeraDigitoVerificadorEtiquetasRequest(client)
                {
                    Etiquetas = etiquetas
                };

                _ = client.GeraDigitoVerificadorEtiquetas(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnObterEmbalagemLrs_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                var request = new ObterEmbalagemLrsRequest()
                {
                };

                _ = client.ObterEmbalagemLrs(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnValidaEtiquetaPlp_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string numeroetiqueta = InputBox("Informe o numero da etiqueta", "SZ999966388BR");
                string idplp = InputBox("Informe o idplp", "04162");

                var request = new ValidaEtiquetaPlpRequest(client)
                {
                    NumeroEtiqueta = numeroetiqueta,
                    IdPlp = long.Parse(idplp)
                };

                _ = client.ValidaEtiquetaPlp(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnBuscaServicosValorDeclarado_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                var request = new BuscaServicosValorDeclaradoRequest(client)
                {
                };

                _ = client.BuscaServicosValorDeclarado(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnConsultaCep_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string cep = InputBox("Informe o cep", "01001900");

                var request = new ConsultaCepRequest()
                {
                    Cep = cep
                };

                //endereco: Objeto com o endereço de retorno
                _ = client.ConsultaCep(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnIntegrarUsuarioScol_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codigoadministrativo = "17000190";

                codigoadministrativo = InputBox("codigo administrativo", codigoadministrativo);

                if (string.IsNullOrEmpty(codigoadministrativo))
                    return;

                var request = new IntegrarUsuarioScolRequest(client)
                {
                    CodAdministrativo = int.Parse(codigoadministrativo)
                };

                _ = client.IntegrarUsuarioScol(request); // Ocorreu um erro de comunicação ao tentar integrar o Usuário no sistema de coleta.

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnPesquisarDimensoesServico_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codigo = "04162";
                string embalagem = "002";

                codigo = InputBox("codigo", codigo);
                embalagem = InputBox("embalagem", embalagem);

                if (string.IsNullOrEmpty(codigo) || string.IsNullOrEmpty(embalagem))
                    return;

                var request = new PesquisarDimensoesServicoRequest()
                {
                    Codigo = codigo,
                    Embalagem = embalagem
                };

                _ = client.PesquisarDimensoesServico(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }

        }

        private void BtnPesquisarEmbalagensPorServico_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codigo = "04162";

                codigo = InputBox("codigo", codigo);

                if (string.IsNullOrEmpty(codigo))
                    return;

                var request = new PesquisarEmbalagensPorServicoRequest()
                {
                    Codigo = codigo

                };

                _ = client.PesquisarEmbalagensPorServico(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnAtualizaRemessaAgrupada_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                var request = new AtualizaRemessaAgrupadaRequest(client)
                {
                };

                _ = client.AtualizaRemessaAgrupada(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnSolicitaPlp_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string idplpmaster = InputBox("Informe o idplp master", string.Empty);
                string numetiqueta = InputBox("Informe o numero da etiqueta", "DL746686536BR");

                var request = new SolicitaPlpRequest(client)
                {
                    IdPlpMaster = long.Parse(idplpmaster),
                    NumEtiqueta = numetiqueta
                };

                _ = client.SolicitaPlp(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnGetStatusCartaoPostagem_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string numerocartaopostagem = InputBox("Informe o numero do cartão postagem", "0067599079");

                var request = new GetStatusCartaoPostagemRequest(client)
                {
                    NumeroCartaoPostagem = numerocartaopostagem
                };

                _ = client.GetStatusCartaoPostagem(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnVerificaModalTransporte_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codigoservico = InputBox("Informe o codigo do serviço", "04162");
                string ceporigem = InputBox("Informe o cep de origem", "05311900");
                string cepdestino = InputBox("Informe o cep de destino", "05311900");

                var request = new VerificaModalTransporteRequest(client)
                {
                    CodigoServico = codigoservico,
                    CepOrigem = ceporigem,
                    CepDestino = cepdestino
                };

                _ = client.VerificaModalTransporte(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnBuscaDataAtual_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                var request = new BuscaDataAtualRequest()
                {
                };

                _ = client.BuscaDataAtual(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnBuscaTarifaVale_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codadministrativo = InputBox("Informe o codigo administrativo", "17000190");
                string codservico = InputBox("Informe o codigo do serviço", string.Empty);
                string ceporigem = InputBox("Informe o cep de origem", "05311900");
                string cepdestino = InputBox("Informe o cep de destino", "05311900");
                string peso = InputBox("Informe o peso", "30");
                string codformato = InputBox("Informe o formato", "1");
                string comprimento = InputBox("Informe o comprimento", "0");
                string altura = InputBox("Informe o altura ", "0");
                string largura = InputBox("Informe o largura", "0");
                string valordeclarado = InputBox("Informe o valor declarado", "20");
                string servicosadicionais = InputBox("Informe o numero do servicos adicionais", "002");

                var request = new BuscaTarifaValeRequest(client)
                {
                    CodAdministrativo = int.Parse(codadministrativo),
                    CodServico = codservico,
                    CepOrigem = ceporigem,
                    CepDestino = cepdestino,
                    Peso = peso,
                    CodFormato = int.Parse(codformato),
                    Comprimento = decimal.Parse(comprimento),
                    Altura = decimal.Parse(altura),
                    Largura = decimal.Parse(largura),
                    ValorDeclarado = decimal.Parse(valordeclarado),
                    ServicoAdicional = servicosadicionais
                };

                _ = client.BuscaTarifaVale(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnValidarPostagemSimultanea_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codadministrativo = InputBox("Informe o codigo administrativo", "17000190");
                string codigoservico = InputBox("Informe o codigo do serviço", string.Empty);
                string idcartaopostagem = InputBox("Informe o cartão postagem", "0067599079");
                string cepdestinatario = InputBox("Informe o cep destinatario", "05311900");
                string coletaobjeto = InputBox("Informe o objeto de coleta", string.Empty);
                string coletaobservacao = InputBox("Informe a observação da coleta", string.Empty);

                var request = new ValidarPostagemSimultaneaRequest(client)
                {
                    CodAdministrativo = int.Parse(codadministrativo),
                    CodigoServico = int.Parse(codigoservico),
                    IdCartaoPostagem = idcartaopostagem,
                    CepDestinatario = cepdestinatario,
                    Coleta = new ColetaSimultanea()
                    {
                        Obj = coletaobjeto,
                        Obs = coletaobservacao
                    }
                };

                _ = client.ValidarPostagemSimultanea(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnGetStatusPlp_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string arg0 = InputBox("Informe o codigo do serviço", string.Empty);
                string arg1 = InputBox("Informe o codigo do serviço", string.Empty);

                var request = new GetStatusPlpRequest(client)
                {
                    Arg0 = new List<ObjetoPostal>(),
                    Arg1 = arg1
                };
                _ = client.GetStatusPlp(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnPesquisarServicosAdicionais_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codigo = "04162";

                codigo = InputBox("codigo", codigo);

                if (string.IsNullOrEmpty(codigo))
                    return;

                var request = new PesquisarServicosAdicionaisRequest()
                {
                    Codigo = codigo
                };

                _ = client.PesquisarServicosAdicionais(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnBuscaServicosXServicosAdicionais_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                var request = new BuscaServicosXServicosAdicionaisRequest(client)
                {
                };

                _ = client.BuscaServicosXServicosAdicionais(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnCancelarPedidoScol_Click(object sender, EventArgs e)
        {
            string codigoadministrativo = "17000190";
            string idpostagem = "0067599079";
            string tipo = "1";

            codigoadministrativo = InputBox("Informe o codigo administrativo", codigoadministrativo);
            idpostagem = InputBox("Informe o id postagem", idpostagem);
            tipo = InputBox("Informe o tipo", tipo);

            if (string.IsNullOrEmpty(codigoadministrativo) || string.IsNullOrEmpty(idpostagem) || string.IsNullOrEmpty(tipo))
                return;
            using (var client = GetClient())
            {
                var request = new CancelarPedidoScolRequest(client)
                {
                    CodAdministrativo = codigoadministrativo,
                    IdPostagem = idpostagem,
                    Tipo = tipo
                };

                _ = client.CancelarPedidoScol(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnBuscaContrato_Click(object sender, EventArgs e)
        {
            string numero = "9992157880";
            string diretoria = "10"; // Código da diretoria regional

            numero = InputBox("Informe o numero", numero);
            diretoria = InputBox("Informe a diretoria", diretoria);

            if (string.IsNullOrEmpty(numero) || string.IsNullOrEmpty(diretoria))
                return;

            using (var client = GetClient())
            {
                var request = new BuscaContratoRequest(client)
                {
                    Numero = numero,
                    Diretoria = long.Parse(diretoria),
                };

                var contratoErp = client.BuscaContrato(request); // Erro 504 gateway timeout 

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = $"{contratoErp} contratoErp!";
            }
        }

        private void BtnSolicitaEtiquetas_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string tipodestinatario = "C";
                string identificador = "34028316000103";
                string idservico = "124849";
                string qtdetiquetas = "1";

                tipodestinatario = InputBox("Identificação com a letra “C”,de cliente.", tipodestinatario);
                identificador = InputBox("CNPJ da empresa, informar somente os números.", identificador);
                idservico = InputBox("Informe o id do serviço", idservico);
                qtdetiquetas = InputBox("Quantidade de etiquetas a ser solicitada", qtdetiquetas);

                if (string.IsNullOrEmpty(tipodestinatario))
                    return;
                var request = new SolicitaEtiquetasRequest(client)
                {
                    TipoDestinatario = tipodestinatario,
                    Identificador = identificador,
                    IdServico = long.Parse(idservico),
                    QtdEtiquetas = int.Parse(qtdetiquetas)
                };

                _ = client.SolicitaEtiquetas(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnSolicitaXmlPlp_Click(object sender, EventArgs e)
        {
            string idplpmaster = string.Empty;

            idplpmaster = InputBox("Informe o idplp master", idplpmaster);

            if (string.IsNullOrEmpty(idplpmaster))
                return;

            using (var client = GetClient())
            {
                var request = new SolicitaXmlPlpRequest(client)
                {
                    IdPlpMaster = long.Parse(idplpmaster)
                };

                _ = client.SolicitaXmlPlp(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnValidarPostagemReversa_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string codadministrativo = InputBox("Informe o codigo administrativo", "17000190");
                string codservico = InputBox("Informe o codigo do serviço", string.Empty);
                string cepdestinatario = InputBox("Informe o cep destinatario", "05311900");
                string idcartaopostagem = InputBox("Informe o cartão postagem", "0067599079");
                string coletaagendamento = InputBox("Informe o agendamento da coleta", string.Empty);
                string coletaavisoderecebimento = InputBox("Informe o aviso de recebimento da coleta", string.Empty);
                string coletacartao = InputBox("Informe o cartão da coleta", string.Empty);
                string coletanumero = InputBox("Informe o numero da coleta", string.Empty);
                string coletaobjeto = InputBox("Informe o objeto da coleta", string.Empty);
                string coletaservicoadicional = InputBox("Informe o serviço adicional da coleta", string.Empty);

                var request = new ValidarPostagemReversaRequest(client)
                {
                    CodAdministrativo = codadministrativo,
                    CodigoServico = codservico,
                    CepDestinatario = cepdestinatario,
                    IdCartaoPostagem = idcartaopostagem,
                    Coleta = new ColetaReversa()
                    {
                        Ag = coletaagendamento,
                        Ar = int.Parse(coletaavisoderecebimento),
                        Cartao = coletacartao,
                        Numero = int.Parse(coletanumero),
                        ObjCol = new List<Objeto>(),
                        ServicoAdicional = coletaservicoadicional
                    }
                };

                _ = client.ValidarPostagemReversa(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnBloquearObjeto_Click_1(object sender, EventArgs e)
        {
            string idplp = "80790";
            string numeroetiqueta = "SG037892748BR";
            string tipobloqueio = "Fraude_Bloqueio"; //Erro: Tipo de Bloqueio incorreto'
            string acao = "Devolvido_Ao_Remetente";

            idplp = InputBox("Informe o idPlp", idplp);
            numeroetiqueta = InputBox("Informe o numero da etiqueta", numeroetiqueta);
            tipobloqueio = InputBox("Informe o tipo de bloqueio", tipobloqueio);
            acao = InputBox("Informe a ação", acao);

            if (string.IsNullOrEmpty(idplp) || string.IsNullOrEmpty(numeroetiqueta) || string.IsNullOrEmpty(tipobloqueio) || string.IsNullOrEmpty(acao))
                return;

            using (var client = GetClient())
            {
                var request = new BloquearObjetoRequest(client)
                {
                    IdPlp = idplp,
                    NumeroEtiqueta = numeroetiqueta,
                    TipoBloqueio = TipoBloqueio.Fraude_Bloqueio,
                    Acao = Acao.Devolvido_Ao_Remetente
                };

                _ = client.BloquearObjeto(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnBuscaCliente_Click(object sender, EventArgs e)
        {
            string idcontrato = "9992157880";
            string idcartaopostagem = "0067599079";

            idcontrato = InputBox("Id do contrato", idcontrato);
            idcartaopostagem = InputBox("Id do cartão postagem", idcartaopostagem);

            if (string.IsNullOrEmpty(idcontrato) || string.IsNullOrEmpty(idcartaopostagem))
                return;

            using (var client = GetClient())
            {
                var request = new BuscaClienteRequest(client)
                {
                    IdContrato = idcontrato,
                    IdCartaoPostagem = idcartaopostagem
                };

                _ = client.BuscaCliente(request); //O buscaCliente tem um retorno grande por isso demora

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnBuscaPagamentoEntrega_Click(object sender, EventArgs e)
        {
            string contrato = "9992157880";
            string etiqueta = string.Empty;

            contrato = InputBox("Informe o contrato", contrato);
            etiqueta = InputBox("Informe a etiqueta", etiqueta);

            using (var client = GetClient())
            {
                var request = new BuscaPagamentoEntregaRequest(client)
                {
                    Contrato = contrato,
                    Etiqueta = etiqueta
                };

                _ = client.BuscaPagamentoEntrega(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnSolicitarPostagemScol_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string xml = string.Empty;
                string codadministrativo = "17000190";

                xml = InputBox("Informe o xml", xml);
                codadministrativo = InputBox("Informe o codigo administrativo", codadministrativo);

                if (string.IsNullOrEmpty(codadministrativo) || string.IsNullOrEmpty(xml))
                    return;

                var request = new SolicitarPostagemScolRequest(client)
                {
                    XmlPlp = xml,
                    CodAdministrativo = int.Parse(codadministrativo)
                };

                _ = client.SolicitarPostagemScol(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnObterMensagemParametrizada_Click(object sender, EventArgs e)
        {
            using (var client = GetClient())
            {
                string id = "9992157880";

                id = InputBox("Informe o id", id);

                if (string.IsNullOrEmpty(id))
                    return;

                var request = new ObterMensagemParametrizadaRequest()
                {
                    Id = id
                };

                _ = client.ObterMensagemParametrizada(request);

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnBuscaOpcoes_Click(object sender, EventArgs e)
        {
            string listaobjetos = "1";
            string tiporesultado = "1";

            listaobjetos = InputBox("Informe o objeto", listaobjetos);
            tiporesultado = InputBox("Informe o tipo", tiporesultado);

            if (string.IsNullOrEmpty(listaobjetos) || string.IsNullOrEmpty(tiporesultado))
                return;

            using (var client = GetClient())
            {
                var request = new BuscaOpcoesRequest(client)
                {
                    ListaObjetos = listaobjetos,
                    TipoResultado = tiporesultado
                };

                _ = client.BuscaOpcoes(request); // Erro: Usuário ou senha inválidos

                TextXmlEnvio.Text = client.XmlEnvio;
                TextXmlResposta.Text = client.XmlResposta;
            }
        }

        private void BtnCorreiosLog_Click(object sender, EventArgs e)
        {

            string xmlcontent = File.ReadAllText(@"C:\temp\xmlzuado.xml", Encoding.UTF8);

            //Remove formatações do XML
            xmlcontent = xmlcontent.Replace(Environment.NewLine, string.Empty);
            xmlcontent = xmlcontent.Replace("	", string.Empty);

            //Corrige CData zuado
            xmlcontent = xmlcontent.Replace(@"]]>><![CDATA[", @">");

            var objeto = CorreiosLog.Load(xmlcontent, Encoding.UTF8);
            objeto.VersaoArquivo = "2.3";

            xmlcontent = objeto.GetXml();
            Console.WriteLine(xmlcontent);
            MessageBox.Show(xmlcontent);



            //using (var client = GetClient())
            //{
            //    string tipoarquivo = InputBox("Informe o tipo arquivo", "Postagem");
            //    string versaoarquivo = InputBox("Informe a versão do arquivo", "2.3");
            //    string plp = InputBox("Informe a plp", "468087125");
            //    string remetente = InputBox("Informe o remetente", "9912318446");
            //    string formapagamento = InputBox("Informe a forma do pagamento", string.Empty);
            //    string objetopostal = InputBox("Informe o objeto postal", "03220");

            //    var request = new CorreiosLogRequest()
            //    {
            //        CorreiosLog = new CorreiosLog()
            //        {
            //            TipoArquivo = tipoarquivo,
            //            VersaoArquivo = versaoarquivo,
            //            Plp = new PlpLog(),
            //            Remetente = new RemetenteLog(),
            //            FormaPagamento = formapagamento,
            //            ObjetoPostalLog = new List<ObjetoPostalLog>()
            //        }
            //    };
            //    _ = client.CorreiosLog(request);

            //    TextXmlEnvio.Text = client.XmlEnvio;
            //    TextXmlResposta.Text = client.XmlResposta;
            //}
        }
    }
}
