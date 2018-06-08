namespace MinisterioDasArtes.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MA07_PessoHabilidade
    {
        public int Id { get; set; }

        public int IdPessoa { get; set; }

        public int IdHabilidade { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? DtaAtualizacao { get; set; }

        public int? IdPessoaCRUD { get; set; }

        public virtual MA01_Pessoa MA01_Pessoa { get; set; }

        public virtual MA09_Habilidade MA09_Habilidade { get; set; }
    }
}
