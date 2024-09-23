using Containers.WEB.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Containers.WEB.Controllers
{
    public class ContenedorController : Controller
    {
        // Lista: Creamos una lista de contenedores en base a nuestro modelo de Contenedor creado. 
        private List<ContenedorVM> _contenedores { get; set; }

        // Constructor: Creamos el constructor del Controller
        public ContenedorController(IContainerManager ContainerManager) {

            this._ContainerManager = ContainerManager;
        

            // Instanciamos una lista de contenedores
            _contenedores = new List<ContenedorVM>();

            // Agregamos dos objetos de tipo ContenedorVM de nuestro modelo
            _contenedores.Add(new ContenedorVM
            {
                IdContainer = 1,
                FechaAlta = DateTime.Now,
                Identificacion = "ASDA-01",
                Ubicacion = "Avenida Siempreviva 2792"
            });

            _contenedores.Add(new ContenedorVM
            {
                IdContainer = 2,
                FechaAlta = DateTime.Now,
                Identificacion = "ASDAASFASD-22343",
                Ubicacion = "Calle Falsa 123"
            });
        }


        // GET: ContenedorController
        public ActionResult Index()
        {
            return View(_contenedores);
        }

        // GET: ContenedorController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContenedorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContenedorController/Create
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

        // GET: ContenedorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContenedorController/Edit/5
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

        // GET: ContenedorController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContenedorController/Delete/5
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
    }
}
