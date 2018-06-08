namespace MinisterioDasArtes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA09_Habilidade
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MA09_Habilidade()
        {
            MA07_PessoHabilidade = new HashSet<MA07_PessoHabilidade>();
        }

        public int id { get; set; }

        [StringLength(128)]
        public string Habilidade { get; set; }

        [StringLength(512)]
        public string Detalhe { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DtaAtualizacao { get; set; }

        public int? IdPessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MA07_PessoHabilidade> MA07_PessoHabilidade { get; set; }
    }
}
