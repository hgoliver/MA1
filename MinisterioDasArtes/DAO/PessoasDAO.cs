
using MinisterioDasArtes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinisterioDasArtes.DAO
{
        public class PessoasDAO
        {
                public void Adiciona(MA01_Pessoa pessoa)
                {
                        using (var context = new MinisterioDasArtes())
                        {
                                context.MA01_Pessoa.Add(pessoa);
                                context.SaveChanges();
                        }
                }

                public IList<MA01_Pessoa> Lista()
                {
                        using (var contexto = new MinisterioDasArtes())
                        {
                                //return contexto.Pessoas.Include("Funcoes").ToList();
                                return contexto.MA01_Pessoa.ToList();
                        }
                }

          

                //public MA01_Pessoa BuscaPorId(int Id)
                //{
                //        using (var contexto = new MinisterioDasArtes())
                //        {
                //                return contexto.Pessoas.First(Id);
                //        }
                //}

                public void Atualiza(MA01_Pessoa pessoa)
                {
                        using (var contexto = new MinisterioDasArtes())
                        {
                                contexto.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
                                contexto.SaveChanges();
                        }
                }

                public MA01_Pessoa Busca(string login)
                {
                        using (var contexto = new MinisterioDasArtes())
                        {
                                return contexto.MA01_Pessoa.FirstOrDefault(u => u.Nome == login);
                        }
                }




        }
}