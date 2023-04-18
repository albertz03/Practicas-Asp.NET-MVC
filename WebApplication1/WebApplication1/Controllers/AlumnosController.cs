using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AlumnosController : Controller
    {
        // GET: HomeController1
        public ActionResult Index()
        {
            //return View();
            var Alumnos = from a in RecuperaAlumnos()
                          orderby a.idAlumno
                          select a;
            return View(Alumnos);   
        }

        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        [NonAction]
        public List<Alumno> RecuperaAlumnos()
        {
            return new List<Alumno>
            {
                new Alumno
                {
                    idAlumno=1,
                    Nombre= "Alberto",
                    ApPaterno= "Soler",
                    ApMaterno= "Romero",
                    FecAlta= DateTime.Parse(DateTime.Today.ToString()),
                    Edad= 30
                },
                new Alumno
                {
                    idAlumno=2,
                    Nombre= "Erik",
                    ApPaterno= "Jara",
                    ApMaterno= "Luna",
                    FecAlta= DateTime.Parse(DateTime.Today.ToString()),
                    Edad= 25
                }
                };
            }

        }
    }


