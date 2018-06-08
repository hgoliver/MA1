namespace MinisterioDasArtes
{
        using System.Data.Entity;
        using global::MinisterioDasArtes.Models;

        public partial class MinisterioDasArtes : DbContext
        {
                public MinisterioDasArtes()
                    : base("name=MinisterioDasArtes")
                {
                }

                public virtual DbSet<MA01_Pessoa> MA01_Pessoa { get; set; }
                public virtual DbSet<MA03_PessoaFuncao> MA03_PessoaFuncao { get; set; }
                public virtual DbSet<MA05_Funcao> MA05_Funcao { get; set; }
                public virtual DbSet<MA07_PessoHabilidade> MA07_PessoHabilidade { get; set; }
                public virtual DbSet<MA09_Habilidade> MA09_Habilidade { get; set; }

                protected override void OnModelCreating(DbModelBuilder modelBuilder)
                {
                        modelBuilder.Entity<MA01_Pessoa>()
                            .Property(e => e.Nome)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA01_Pessoa>()
                            .Property(e => e.Apelido)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA01_Pessoa>()
                            .Property(e => e.Email)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA01_Pessoa>()
                            .Property(e => e.Celular1)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA01_Pessoa>()
                            .Property(e => e.Celular2)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA01_Pessoa>()
                            .Property(e => e.Tefelone)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA01_Pessoa>()
                            .Property(e => e.Senha)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA01_Pessoa>()
                            .HasMany(e => e.MA03_PessoaFuncao)
                            .WithRequired(e => e.MA01_Pessoa)
                            .HasForeignKey(e => e.IdPessoa)
                            .WillCascadeOnDelete(false);

                        modelBuilder.Entity<MA01_Pessoa>()
                            .HasMany(e => e.MA07_PessoHabilidade)
                            .WithRequired(e => e.MA01_Pessoa)
                            .HasForeignKey(e => e.IdPessoa)
                            .WillCascadeOnDelete(false);

                        modelBuilder.Entity<MA05_Funcao>()
                            .Property(e => e.NomeFuncao)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA05_Funcao>()
                            .Property(e => e.DescFuncao)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA05_Funcao>()
                            .HasMany(e => e.MA03_PessoaFuncao)
                            .WithRequired(e => e.MA05_Funcao)
                            .HasForeignKey(e => e.IdFuncao)
                            .WillCascadeOnDelete(false);

                        modelBuilder.Entity<MA09_Habilidade>()
                            .Property(e => e.Habilidade)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA09_Habilidade>()
                            .Property(e => e.Detalhe)
                            .IsUnicode(false);

                        modelBuilder.Entity<MA09_Habilidade>()
                            .HasMany(e => e.MA07_PessoHabilidade)
                            .WithRequired(e => e.MA09_Habilidade)
                            .HasForeignKey(e => e.IdHabilidade)
                            .WillCascadeOnDelete(false);
                }
        }
}
