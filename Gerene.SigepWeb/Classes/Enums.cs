using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using ACBr.Net.DFe.Core.Attributes;

namespace Gerene.SigepWeb.Classes
{
    public enum StatusGerente
    {
        Inativo = 0,
        Ativo = 1
    }

    public enum TipoGerente
    {
        [DFeEnum("GerenteConta")] 
        GerenteConta = 0,
        [DFeEnum("GerenteContaMaster")] 
        GerenteContaMaster = 1,
    }

    public enum StatusUsuario
    {
        Inativo = 0,
        Ativo = 1
    }

    public enum CategoriaServico
    {
        [DFeEnum("SEM_CATEGORIA")]
        Sem_Categoria = 0,
        [DFeEnum("PAC")]
        Pac = 1,
        [DFeEnum("SEDEX")]
        Sedex = 2,
        [DFeEnum("CARTA")]
        Carta = 3,
        [DFeEnum("GRANDES_FORMATOS")]
        Grandes_Formatos = 4,
        [DFeEnum("REVERSO")]
        Reverso = 5,
    }

    public enum SimNao
    {
        S,
        N
    }

    public enum StatusPlp
    {
        Aberta = 0,
        Fechada = 1,
        Postada = 2
    }

    public enum StatusObjetoPostal
    {
        [DFeEnum("EmBranco")]
        EmBranco = 0,
        [DFeEnum("Postado")]
        Postado = 1,
        [DFeEnum("Cancelado")]
        Cancelado = 8,
        [DFeEnum("Estorno")]
        Estorno = 9
    }

    public enum TipoEmbalagem
    {
        DE,
        PD,
        RL
    }

    public enum StatusCartao 
    {
        Desconhecido = 0,
        Normal = 1,
        Suspenso = 2,
        Cancelado = 3,
        Irregular = 4,
    }

    public enum TipoBloqueio
    {
        [DFeEnum("FRAUDE_BLOQUEIO")]
        Fraude_Bloqueio = 0,
        [DFeEnum("EXTRAVIO_VAREJO_PRE_INDENIZADO")]
        Extravio_Varejo_Pre_Indenizado = 1,
        [DFeEnum("EXTRAVIO_VAREJO_POS_INDENIZADO")]
        Extravio_Varejo_Pos_Indenizado = 2,
        [DFeEnum("EXTRAVIO_CORPORATIVO")]
        Extravio_Corporativo = 3,
        [DFeEnum("INTERNACIONAL_LDI")]
        Internacional_Ldi = 4,
    } 

    public enum Acao
    {
        [DFeEnum("DEVOLVIDO_AO_REMETENTE")]
        Devolvido_Ao_Remetente = 0,
        [DFeEnum("ENCAMINHADO_PARA_REFUGO")]
        Encaminhado_Para_Refugo = 1,
        [DFeEnum("REINTEGRADO_E_DEVOLVIDO_AO_REMETENTE")]
        Reintegrado_E_Devolvido_Ao_Remetente = 2,
        [DFeEnum("DESBLOQUEADO")]
        Desbloqueado = 3,
    }

    public enum TipoMensagem
    {
        A,
        E,
        S
    }
}
