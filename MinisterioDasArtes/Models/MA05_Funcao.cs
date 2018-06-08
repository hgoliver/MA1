namespace MinisterioDasArtes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA05_Funcao
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MA05_Funcao()
        {
            MA03_PessoaFuncao = new HashSet<MA03_PessoaFuncao>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(128)]
        public string NomeFuncao { get; set; }

        [StringLength(512)]
        public string DescFuncao { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DtaAtualizacao { get; set; }

        public int? IdPessoa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MA03_PessoaFuncao> MA03_PessoaFuncao { get; set; }
    }
}
