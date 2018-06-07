namespace Models.MA1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IBBCA05_RESULTADO_PESQUISA
    {
        public int Id { get; set; }

        public int IdVigenciaContratual { get; set; }

        public int IdSolicitacaoPesquisa { get; set; }

        public byte NroOlProprietario { get; set; }

        public byte NroOlArrecadacao { get; set; }

        public short NroConveniada { get; set; }

        public int NroInscricao { get; set; }

        public int? NroPlano { get; set; }

        public byte QtdVidas { get; set; }

        [Column(TypeName = "numeric")]
        public decimal NroCPF { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DtaNascimento { get; set; }

        [Column(TypeName = "money")]
        public decimal VlrCobranca { get; set; }

        [Column(TypeName = "money")]
        public decimal? VlrRecebido { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DtaPagamento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DtaInscricao { get; set; }

        public byte NroTpoReceita { get; set; }

        [StringLength(4)]
        public string TpoPesquisa { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DtaAtualizacao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UserId { get; set; }

        public virtual IBBCA01_VIGENCIA_CONTRATUAL IBBCA01_VIGENCIA_CONTRATUAL { get; set; }

        public virtual IBBCA03_SOLICITACAO_PESQUISA IBBCA03_SOLICITACAO_PESQUISA { get; set; }
    }
}
