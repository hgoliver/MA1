using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Models.MA1;

namespace Context.MA1
{


        public partial class MA1 : DbContext
        {
                public MA1()
                    : base("name=MA1")
                {
                }

                public virtual DbSet<IBBCA01_VIGENCIA_CONTRATUAL> VIGENCIA_CONTRATUAL { get; set; }
                public virtual DbSet<IBBCA03_SOLICITACAO_PESQUISA> SOLICITACAO_PESQUISA { get; set; }
                public virtual DbSet<IBBCA05_RESULTADO_PESQUISA> RESULTADO_PESQUISA { get; set; }
                //public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

                protected override void OnModelCreating(DbModelBuilder modelBuilder)
                {
                        modelBuilder.Entity<IBBCA01_VIGENCIA_CONTRATUAL>()
                            .Property(e => e.TxtDescLiberacao)
                            .IsUnicode(false);

                        modelBuilder.Entity<IBBCA01_VIGENCIA_CONTRATUAL>()
                            .Property(e => e.UserId)
                            .HasPrecision(11, 0);

                        modelBuilder.Entity<IBBCA01_VIGENCIA_CONTRATUAL>()
                            .HasMany(e => e.IBBCA05_RESULTADO_PESQUISA)
                            .WithRequired(e => e.IBBCA01_VIGENCIA_CONTRATUAL)
                            .HasForeignKey(e => e.IdVigenciaContratual)
                            .WillCascadeOnDelete(false);

                        modelBuilder.Entity<IBBCA03_SOLICITACAO_PESQUISA>()
                            .Property(e => e.TxtDesc)
                            .IsUnicode(false);

                        modelBuilder.Entity<IBBCA03_SOLICITACAO_PESQUISA>()
                            .Property(e => e.UserId)
                            .HasPrecision(11, 0);

                        modelBuilder.Entity<IBBCA03_SOLICITACAO_PESQUISA>()
                            .HasMany(e => e.IBBCA05_RESULTADO_PESQUISA)
                            .WithRequired(e => e.IBBCA03_SOLICITACAO_PESQUISA)
                            .HasForeignKey(e => e.IdSolicitacaoPesquisa)
                            .WillCascadeOnDelete(false);

                        modelBuilder.Entity<IBBCA05_RESULTADO_PESQUISA>()
                            .Property(e => e.NroCPF)
                            .HasPrecision(11, 0);

                        modelBuilder.Entity<IBBCA05_RESULTADO_PESQUISA>()
                            .Property(e => e.VlrCobranca)
                            .HasPrecision(19, 4);

                        modelBuilder.Entity<IBBCA05_RESULTADO_PESQUISA>()
                            .Property(e => e.VlrRecebido)
                            .HasPrecision(19, 4);

                        modelBuilder.Entity<IBBCA05_RESULTADO_PESQUISA>()
                            .Property(e => e.TpoPesquisa)
                            .IsUnicode(false);

                        modelBuilder.Entity<IBBCA05_RESULTADO_PESQUISA>()
                            .Property(e => e.UserId)
                            .HasPrecision(11, 0);
                }
        }
}
