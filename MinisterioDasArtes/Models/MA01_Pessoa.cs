namespace MinisterioDasArtes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA01_Pessoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MA01_Pessoa()
        {
            MA03_PessoaFuncao = new HashSet<MA03_PessoaFuncao>();
            MA07_PessoHabilidade = new HashSet<MA07_PessoHabilidade>();
        }

        public int Id { get; set; }

        [StringLength(256)]
        public string Nome { get; set; }

        [StringLength(50)]
        public string Apelido { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DtNascimento { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(11)]
        public string Celular1 { get; set; }

        [StringLength(11)]
        public string Celular2 { get; set; }

        [StringLength(11)]
        public string Tefelone { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DtaAtualizacao { get; set; }

        public int? IdPessoa { get; set; }

        public bool? StaAdminSistema { get; set; }

        [StringLength(50)]
        public string Senha { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MA03_PessoaFuncao> MA03_PessoaFuncao { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MA07_PessoHabilidade> MA07_PessoHabilidade { get; set; }
    }
}
