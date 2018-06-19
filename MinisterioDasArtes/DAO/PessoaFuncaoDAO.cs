
using MinisterioDasArtes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinisterioDasArtes.DAO
{
        public class PessoaFuncaoDAO
        {
                public void Adiciona(MA03_PessoaFuncao pessoaFuncao)
                {
                        using (var context = new MinisterioDasArtes())
                        {
                                context.MA03_PessoaFuncao.Add(pessoaFuncao);
                                context.SaveChanges();
                        }
                }

                //public IList<MA01_Pessoa> Lista()
                //{
                //        using (var contexto = new MinisterioDasArtes())
                //        {
                //                //return contexto.Pessoas.Include("Funcoes").ToList();
                //                return contexto.MA01_Pessoa.ToList();
                //        }
                //}

          

                //public MA01_Pessoa BuscaPorId(int Id)
                //{
                //        using (var contexto = new MinisterioDasArtes())
                //        {
                //                return contexto.Pessoas.First(Id);
                //        }
                //}

                //public void Atualiza(MA03_PessoaFuncao pessoa)
                //{
                //        using (var contexto = new MinisterioDasArtes())
                //        {
                //                contexto.Entry(pessoa).State = System.Data.Entity.EntityState.Modified;
                //                contexto.SaveChanges();
                //        }
                //}

                //public MA01_Pessoa Busca(string login)
                //{
                //        using (var contexto = new MinisterioDasArtes())
                //        {
                //                return contexto.MA01_Pessoa.FirstOrDefault(u => u.Nome == login);
                //        }
                //}




        }
}