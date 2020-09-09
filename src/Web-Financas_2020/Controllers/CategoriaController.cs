using System.Linq;
using Application.Interfaces.ICategoriasApp;
using Application.Interfaces.ISistemaApp.ISistemasFinanceirosApp;
using Entity.Entities.Categorias;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Internal;
using System.Security.AccessControl;
using System;
using System.Security.Cryptography.Xml;
using System.Collections.Generic;

namespace Web_Financas_2020.Controllers
{
    [Authorize]
    public class CategoriaController : Controller
    {
        private readonly IAppCategoria _appCategoria;
        private readonly IAppSistemaFinanceiro _sistemaFinanceiro;

        public CategoriaController(IAppCategoria appCategoria, IAppSistemaFinanceiro sistemaFinanceiro)
        {
            _appCategoria = appCategoria;
            _sistemaFinanceiro = sistemaFinanceiro;
        }
        // GET: CategoriaController
        public ActionResult Index()
        {
            return View(_appCategoria.ListarCategoriasUsuario(User.Identity.Name));
        }

        // GET: CategoriaController/Details/5
        public ActionResult Details(int id)
        {
            ViewData["IdSistema"] = new SelectList(_sistemaFinanceiro.ListaSistemasUsuario(User.Identity.Name), "Id", "Nome");
            return View(_appCategoria.GetEntityById(id));
        }

        // GET: CategoriaController/Create
        public ActionResult Create()
        {
            ViewData["IdSistema"] = new SelectList(_sistemaFinanceiro.ListaSistemasUsuario(User.Identity.Name), "Id", "Nome");
            return View(new Categoria());
        }

        // POST: CategoriaController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categoria categoria)
        {
            try
            {
                _appCategoria.AdicionarCategoria(categoria);
                if (categoria.notificacoes.Any())
                {
                    foreach (var item in categoria.notificacoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Mensagem);
                    }
                    return View("Create", categoria);
                }
                // return RedirectToAction(nameof(Index));
            }
            catch (Exception ERRO)
            {
                return View(categoria);
            }
            ViewData["IdSistema"] = new MultiSelectList(_sistemaFinanceiro.ListaSistemasUsuario(User.Identity.Name), "Id", "Nome");
            return RedirectToAction("Edit", new { id = categoria.Id });
        }

        // GET: CategoriaController/Edit/5
        public ActionResult Edit(int id)
        {
            ViewData["IdSistema"] = new SelectList(_sistemaFinanceiro.ListaSistemasUsuario(User.Identity.Name), "Id", "Nome");

            return View(_appCategoria.GetEntityById(id));
        }

        // POST: CategoriaController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Categoria categoria)
        {
            ViewData["IdSistema"] = new SelectList(_sistemaFinanceiro.ListaSistemasUsuario(User.Identity.Name), "Id", "Nome");
            try
            {
                _appCategoria.AtualizarCategoria(categoria);

                if (categoria.notificacoes.Any())
                {
                    foreach (var item in categoria.notificacoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Mensagem);
                    }
                    return View("Edit", categoria);
                }

                //  var sistemasUsuario = _sistemaFinanceiro.ListaSistemasUsuario(User.Identity.Name);

                // return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(categoria);
            }

            return RedirectToAction("Edit", new { id = categoria.Id });
        }


        // GET: CategoriaController/Delete/5
        public ActionResult Delete(int id)
        {
            ViewData["IdSistema"] = new SelectList(_sistemaFinanceiro.ListaSistemasUsuario(User.Identity.Name), "Id", "Nome");
            return View(_appCategoria.GetEntityById(id));
        }

        // POST: CategoriaController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Categoria categoria)
        {
            try
            {
                _appCategoria.Delete(categoria);

                if (categoria.notificacoes.Any())
                {
                    foreach (var item in categoria.notificacoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Mensagem);
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(categoria);
            }

        }
    }
}
