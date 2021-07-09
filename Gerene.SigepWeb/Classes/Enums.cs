using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;

namespace Gerene.SigepWeb.Classes
{
    public enum StatusGerente
    {
        Inativo = 0,
        Ativo = 1
    }

    public enum TipoGerente
    {
        [Description("GerenteConta")] 
        GerenteConta = 0,
        [Description("GerenteContaMaster")] 
        GerenteContaMaster = 1,
    }

    public enum StatusUsuario
    {
        Inativo = 0,
        Ativo = 1
    }

    public enum CategoriaServico
    {
        [Description("SEM_CATEGORIA")]
        Sem_Categoria = 0,
        [Description("PAC")]
        Pac = 1,
        [Description("SEDEX")]
        Sedex = 2,
        [Description("CARTA")]
        Carta = 3,
        [Description("GRANDES_FORMATOS")]
        Grandes_Formatos = 4,
        [Description("REVERSO")]
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
        [Description("EmBranco")]
        EmBranco = 0,
        [Description("Postado")]
        Postado = 1,
        [Description("Cancelado")]
        Cancelado = 8,
        [Description("Estorno")]
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
        [Description("FRAUDE_BLOQUEIO")]
        Fraude_Bloqueio = 0,
        [Description("EXTRAVIO_VAREJO_PRE_INDENIZADO")]
        Extravio_Varejo_Pre_Indenizado = 1,
        [Description("EXTRAVIO_VAREJO_POS_INDENIZADO")]
        Extravio_Varejo_Pos_Indenizado = 2,
        [Description("EXTRAVIO_CORPORATIVO")]
        Extravio_Corporativo = 3,
        [Description("INTERNACIONAL_LDI")]
        Internacional_Ldi = 4,
    } 

    public enum Acao
    {
        [Description("DEVOLVIDO_AO_REMETENTE")]
        Devolvido_Ao_Remetente = 0,
        [Description("ENCAMINHADO_PARA_REFUGO")]
        Encaminhado_Para_Refugo = 1,
        [Description("REINTEGRADO_E_DEVOLVIDO_AO_REMETENTE")]
        Reintegrado_E_Devolvido_Ao_Remetente = 2,
        [Description("DESBLOQUEADO")]
        Desbloqueado = 3,
    }

    public enum TipoMensagem
    {
        A,
        E,
        S
    }
}
