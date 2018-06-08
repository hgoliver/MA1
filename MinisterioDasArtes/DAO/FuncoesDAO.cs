using MinisterioDasArtes.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace MinisterioDasArtes.DAO
{
        public class FuncoesDAO
        {
//teste

                public void Adiciona(MA05_Funcao funcao)
                {
                        using (var context = new MinisterioDasArtes())
                        {
                                context.MA05_Funcao.Add(funcao);
                                context.SaveChanges();
                        }
                }

                public IList<MA05_Funcao> Lista()
                {
                        using (var contexto = new MinisterioDasArtes())
                        {
                                return contexto.MA05_Funcao.ToList();
                        }
                }

                public MA05_Funcao BuscaPorId(int id)
                {
                        using (var contexto = new MinisterioDasArtes())
                        {
                                return contexto.MA05_Funcao.Find(id);
                        }
                }

                public void Atualiza(MA05_Funcao funcao)
                {
                        using (var contexto = new MinisterioDasArtes())
                        {
                                contexto.Entry(funcao).State = System.Data.Entity.EntityState.Modified;
                                contexto.SaveChanges();
                        }
                }

        }
}