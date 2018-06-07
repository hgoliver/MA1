namespace Models.MA1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IBBCA01_VIGENCIA_CONTRATUAL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IBBCA01_VIGENCIA_CONTRATUAL()
        {
            IBBCA05_RESULTADO_PESQUISA = new HashSet<IBBCA05_RESULTADO_PESQUISA>();
        }

        public int Id { get; set; }

        [StringLength(256)]
        public string TxtDescLiberacao { get; set; }

        public short? NroConveniada { get; set; }

        public byte? NroOl { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DtaIniValidade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DtaFimValidade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DtaCancelamento { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime DtaAtualizacao { get; set; }

        [Column(TypeName = "numeric")]
        public decimal UserId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<IBBCA05_RESULTADO_PESQUISA> IBBCA05_RESULTADO_PESQUISA { get; set; }
    }
}
