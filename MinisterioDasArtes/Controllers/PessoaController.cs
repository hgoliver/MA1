using System.Collections.Generic;
using System.Web.Mvc;
using MinisterioDasArtes.DAO;
using MinisterioDasArtes.DTO;
using MinisterioDasArtes.Models;



namespace MinisterioDasArtes.Controllers
{
        public class PessoaController : Controller
        {
                // GET: Pessoa
                public ActionResult Index()
                {
                        PessoasDAO DAO = new PessoasDAO();
                        IList<MA01_Pessoa> pessoas = DAO.Lista();
                        ViewBag.Pessoas = pessoas;

                        return View();
                }

                public ActionResult Form()
                {
                        FuncoesDAO DAO = new FuncoesDAO();
                        IList<MA05_Funcao> funcoes = DAO.Lista();
                        ViewBag.Funcoes = funcoes;

                        return View();
                }

                [HttpPost]
                public ActionResult Adiciona(PessoaDTO pessoaDTO)
                {
                        MA01_Pessoa pessoa = new MA01_Pessoa()
                        {
                                Nome = pessoaDTO.Nome
                        };

                        MA03_PessoaFuncao pessoaFuncao = new MA03_PessoaFuncao()
                        {
                                MA01_Pessoa = pessoa,
                                IdFuncao = pessoaDTO.FuncaoId
                        };

                        new PessoaFuncaoDAO().Adiciona(pessoaFuncao);

                        return RedirectToAction("Index", "Pessoa");
                }

        }
}