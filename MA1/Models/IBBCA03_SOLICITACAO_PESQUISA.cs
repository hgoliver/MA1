namespace Models.MA1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IBBCA03_SOLICITACAO_PESQUISA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IBBCA03_SOLICITACAO_PESQUISA()
        {
            IBBCA05_RESULTADO_PESQUISA = new HashSet<IBBCA05_RESULTADO_PESQUISA>();
        }

        public int Id { get; set; }

        [StringLength(512)]
        public string TxtDesc { get; set; }

        public byte? NroOl { get; set; }

        public short? NroConveniada { get; set; }

        public byte? NroMesExercicioPesquisa { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DtaInicio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DtaFim { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DtaAtualizacao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IBBCA05_RESULTADO_PESQUISA> IBBCA05_RESULTADO_PESQUISA { get; set; }
    }
}
