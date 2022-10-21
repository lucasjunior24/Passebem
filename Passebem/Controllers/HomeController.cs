using Microsoft.AspNetCore.Mvc;
using Passebem.Data;
using Passebem.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Passebem.Controllers
{
    public class HomeController : Controller
    {

        private PassaBemContext db = new PassaBemContext();

        public HomeController()
        {


        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Estado estado)
        {
            if (ModelState.IsValid)
            {
                db.Estados.Add(estado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(estado);
        }

        [HttpGet]
        public ActionResult ObterTodosEstados()
        {
            if (ModelState.IsValid)
            {
                var estados = db.Estados.AsNoTracking().ToList();
                return View(estados);
            }

            return View(new List<Estado>());
        }

        [HttpGet]
        public ActionResult OnterClima()
        {
            if (ModelState.IsValid)
            {
                var cidades = db.Cidades.AsNoTracking()
                    .Include(c => c.PrevicoesDoClima).ToList();

                return View(cidades);
            }

            return View(new List<Cidade>());
        }
    }
}