using Application.Interfaces.ICategoriasApp;
using Application.Interfaces.IFluxosApp.IComprasApp;
using Entity.Entities.Fluxos.Compras;
using Infrastructure.Configurations.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace WebFinancas.Controllers
{
    [Authorize]
    public class ComprasController : Controller
    {
        private readonly IAppCompra _iAppCompra;
        private readonly IAppCategoria _iAppCategoria;

        public ComprasController(IAppCompra iAppCompra, IAppCategoria iAppCategoria )
        {
            _iAppCompra = iAppCompra;
            _iAppCategoria = iAppCategoria;
        }

        // GET: Compras
        public IActionResult Index()
        {
            return View(_iAppCategoria.ListarCategoriasUsuario(User.Identity.Name));
        }

        // GET: Compras/Details/5
        public IActionResult Details(int id)
        {
            var compra = _iAppCompra.GetEntityById(id);
            var categoria = _iAppCategoria.GetEntityById(compra.IdCategoria);
            compra.Categoria = categoria;

            return View(compra);       
        }

        // GET: Compras/Create
        public IActionResult Create()
        {
            ViewData["IdCategoria"] = new SelectList(_iAppCategoria.ListarCategoriasUsuario(User.Identity.Name), "Id", "Nome");
            return View(new Compra());
        }

        // POST: Compras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( Compra compra)
        {
            ViewData["IdCategoria"] = new SelectList(_iAppCategoria.ListarCategoriasUsuario(
                                                    User.Identity.Name), "Id", "Nome", 
                                                    compra.IdCategoria);
            try
            {
                _iAppCompra.AdicionarCompra(compra);
                if (compra.notificacoes.Any())
                {
                    foreach (var item in compra.notificacoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Mensagem);
                    }
                    return View("Create", compra);
                }
            }
            catch (Exception erro)
            {

                return View(compra);
            }
            
            return RedirectToAction("Index","Compras");
        }

        // GET: Compras/Edit/5
        public IActionResult Edit(int id)
        {
            var compra = _iAppCompra.GetEntityById(id);
            var categoria = _iAppCategoria.GetEntityById(compra.IdCategoria);
            compra.Categoria = categoria;

            ViewData["IdCategoria"] = new SelectList(_iAppCategoria.ListarCategoriasUsuario(User.Identity.Name), "Id", "Id", compra.IdCategoria);
            return View(compra);
        }

        // POST: Compras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id,Compra compra)
        {
            ViewData["IdCategoria"] = new SelectList(_iAppCategoria.ListarCategoriasUsuario(
                                                    User.Identity.Name), "Id", "Nome",
                                                    compra.IdCategoria);
            try
            {
                _iAppCompra.AtualizarCompra(compra);
                if (compra.notificacoes.Any())
                {
                    foreach (var item in compra.notificacoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Mensagem);
                    }
                    return View("Edit", compra);
                }
            }
            catch (Exception erro)
            {

                return View(compra);
            }

            return RedirectToAction("Edit", new {id = compra.Id });
        }

        // GET: Compras/Delete/5
        public IActionResult Delete(int id)
        {
            return View(_iAppCompra.GetEntityById(id));
        }

        // POST: Compras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, Compra compra)
        {
            try
            {
                _iAppCompra.Delete(compra);
                if (compra.notificacoes.Any())
                {
                    foreach (var item in compra.notificacoes)
                    {
                        ModelState.AddModelError(item.NomePropriedade, item.Mensagem);
                    }
                }
               return RedirectToAction("Index", "Compras");
            }
            catch 
            {

              return  RedirectToAction("Index", "Compras");
            }
        }
    }
}
