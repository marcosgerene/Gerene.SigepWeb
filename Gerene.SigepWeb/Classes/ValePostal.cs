using System;
using System.Collections.Generic;
using System.Text;

using ACBr.Net.DFe.Core.Attributes;
using ACBr.Net.DFe.Core.Document;
using ACBr.Net.DFe.Core.Serializer;

namespace Gerene.SigepWeb.Classes
{
    public sealed class ValePostal : DFeDocument<ValePostal>
    {
        [DFeElement(TipoCampo.Str, "cidNoCidade")]
        public string CidNoCidade { get; set; }

        [DFeElement(TipoCampo.Str, "ctcCoAadministrativo")]
        public string CtcCoAadministrativo { get; set; }

        [DFeElement(TipoCampo.Long, "ctcNuContrato")]
        public long CtcNuContrato { get; set; }

        [DFeElement(TipoCampo.Long, "ctcNuContratoEct")]
        public long CtcNuContratoEct { get; set; }

        [DFeElement(TipoCampo.Str, "cvpEdBairro")]
        public string CvpEdBairro { get; set; }

        [DFeElement(TipoCampo.Str, "cvpEdCliente")]
        public string CvpEdCliente { get; set; }

        [DFeElement(TipoCampo.Str, "cvpEdComplemento")]
        public string CvpEdComplemento { get; set; }

        [DFeElement(TipoCampo.Str, "cvpEdNumero")]
        public string CvpEdNumero { get; set; }

        [DFeElement(TipoCampo.Str, "cvpNoCliente")]
        public string CvpNoCliente { get; set; }

        [DFeElement(TipoCampo.Long, "cvpNuCep")]
        public long CvpNuCep { get; set; }

        [DFeElement(TipoCampo.Str, "descricaoErro")]
        public string DescricaoErro { get; set; }

        [DFeElement(TipoCampo.Str, "estSgEstado")]
        public string EstSgEstado { get; set; }

        [DFeElement(TipoCampo.Int, "monVarTarifaAdicional")]
        public int MonVarTarifaAdicional { get; set; }

        [DFeElement(TipoCampo.Int, "monVarTarifaServico")]
        public int MonVarTarifaServico { get; set; }

        [DFeElement(TipoCampo.Int, "monVarValorDescontos")]
        public int MonVarValorDescontos { get; set; }

        [DFeElement(TipoCampo.Int, "monVarValorImposto")]
        public int MonVarValorImposto { get; set; }

        [DFeElement(TipoCampo.Long, "prsCoProdutoServico")]
        public long PrsCoProdutoServico { get; set; }

        [DFeElement(TipoCampo.Long, "pveNu")]
        public long PveNu { get; set; }

        [DFeElement(TipoCampo.Long, "pveOrgNuAgencia")]
        public long PveOrgNuAgencia { get; set; }

        [DFeElement(TipoCampo.Long, "cvpNuCep")]
        public long PveOrgNuAgenciaDes { get; set; }

        [DFeElement(TipoCampo.Long, "cvpNuCep")]
        public long PveOrgNuAgenciaOri { get; set; }

        [DFeElement(TipoCampo.Int, "retornaCodErro")]
        public int RetornaCodErro { get; set; }

        [DFeElement(TipoCampo.Str, "descricaoErro")]
        public string SitNoSituacao { get; set; }

        [DFeElement(TipoCampo.Str, "estSgEstado")]
        public string TlgTxDescricao { get; set; }

        [DFeElement(TipoCampo.Dat, "vapDhTransacao")]
        public DateTime VapDhTransacao { get; set; }

        [DFeElement(TipoCampo.Str, "vapNuEtiquetaEncomenda")]
        public string VapNuEtiquetaEncomenda { get; set; }

        [DFeElement(TipoCampo.De10, "vapVrCobradoEct")]
        public decimal VapVrCobradoEct { get; set; }

        [DFeElement(TipoCampo.De10, "vapVrNominal")]
        public decimal VapVrNominal { get; set; }

    }
}
