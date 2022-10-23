using Microsoft.AspNetCore.Mvc;
using Passebem.Data;
using Passebem.Models;
using Passebem.ViewModel;
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

        public HomeController(PassaBemContext db)
        {
            this.db = db;
        }

        public HomeController()
        {


        }
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Sobre()
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

                var diaMaisQuentePorCidade = cidades.SelectMany(c => c.PrevicoesDoClima.OrderByDescending(p => p.TemperaturaMaxima).Take(1)).ToList();
                var diaMaisFriosPorCidade = cidades.SelectMany(c => c.PrevicoesDoClima.OrderBy(p => p.TemperaturaMinima).Take(1)).ToList();

                var TresCidadesMaisQuentes = diaMaisQuentePorCidade.OrderByDescending(p => p.TemperaturaMaxima).Take(3).ToList();
                var TresCidadesMaisFrias = diaMaisFriosPorCidade.OrderBy(p => p.TemperaturaMinima).Take(3).ToList();


                var cidadeViewModel = new ClimaViewModel()
                {
                    Cidades = cidades,
                    CidadesMaisFrias = TresCidadesMaisFrias,
                    CidadesMaisQuestes = TresCidadesMaisQuentes
                };

                ViewData["CidadeDisponvel"] = false;
                return View(cidadeViewModel);
            }

            return View(new ClimaViewModel());
        }

        [HttpGet]
        public async Task<ActionResult> ObterClimaPorCidade(int cidadeId)
        {
            if (ModelState.IsValid)
            {
                var cidade = await db.Cidades.AsNoTracking()
                    .Include(c => c.PrevicoesDoClima).FirstOrDefaultAsync(c => c.Id == cidadeId);
                ViewData["CidadeDisponvel"] = true;
                return PartialView("_ClimaPorCidade", cidade);
            }

            return View();
        }
        
    }
}