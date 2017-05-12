using System.Linq;
using AppMvcControleFinanceiro.Entities;
using AppMvcControleFinanceiro.Services;
using Microsoft.AspNetCore.Mvc;

namespace AppMvcControleFinanceiro.Controllers
{
    public class PessoasController : Controller
    {
	    readonly IPessoaService _pessoaApp;
		public PessoasController(IPessoaService pessoaApp)
		{
			_pessoaApp = pessoaApp;
		}

        [HttpGet]
        public IActionResult Index()
        {
            var pessoas = _pessoaApp.GetAll().OrderBy(p => p.Id);
            return View(pessoas);
        }

		// GET: Pessoas/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Pessoas/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Pessoa pessoa)
		{
			if (ModelState.IsValid)
			{
				_pessoaApp.Add(pessoa);

				return RedirectToAction("Index");
			}
            return View(pessoa);
		}

		// GET: Pessoas/Details/5
		public ActionResult Details(int id)
		{
			var pessoa = _pessoaApp.GetById(id);
			return View(pessoa);
		}

		// GET: Pessoas/Edit/5
		public ActionResult Edit(int id)
		{
			var pessoa = _pessoaApp.GetById(id);
			return View(pessoa);
		}

		// POST: Pessoas/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Pessoa pessoa)
		{
			if (ModelState.IsValid)
			{
				_pessoaApp.Update(pessoa);
				return RedirectToAction("Index");
			}
			return View(pessoa);
		}

		// GET: Pessoas/Delete/5
		public ActionResult Delete(int id)
		{
			var pessoa = _pessoaApp.GetById(id);
			return View(pessoa);
		}

		// POST: Pessoas/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public ActionResult DeleteConfirmed(int id)
		{
			var pessoa = _pessoaApp.GetById(id);
			_pessoaApp.Remove(pessoa);
			return RedirectToAction("Index");
		}
    }
}
