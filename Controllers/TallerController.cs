using Microsoft.AspNetCore.Mvc;
using proyectoMVC.Services;
using proyectoMVC.Models;

namespace proyectoMVC.Controllers
{
    public class TallerController : Controller
    {

        private readonly TallerServices tallerServices;

        public TallerController(TallerServices tallerServices)
        {
            this.tallerServices = tallerServices;
        }
        
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var taller = await tallerServices.GetAllTaller();
            return View(taller);
        }

       

        [HttpPost]
        public async Task<IActionResult> Crear(string NombreTienda, string Direccion,  string Telefono, int Empleado)
        {
            var taller = Taller.Build(Guid.NewGuid(), NombreTienda, Direccion, Telefono, Empleado);
            await this.tallerServices.Crear(taller);
            return View();
        }

        [HttpGet]
        public IActionResult Crear()
        {
            return View();
        }

        //Actualizar

        [HttpGet]
        public IActionResult Actualizar(string NombreTienda, string Direccion, string Telefono, int Empleado)
        {
            return View();
        }

        
        public IActionResult Actualizar(Guid id, string NombreTienda, string Direccion, string Telefono, int Empleado)
        {
            var taller = Taller.Build(id, NombreTienda, Direccion, Telefono, Empleado);
            this.tallerServices.Actualizar(taller);
            return RedirectToAction(nameof(Index));
        }

        //Eliminar
        
        public IActionResult Delete(Guid id, string NombreTienda, string Direccion, string Telefono, int Empleado)
        {
            var taller = Taller.Build(id, NombreTienda, Direccion, Telefono, Empleado);
            this.tallerServices.Eliminar(taller);
            return RedirectToAction(nameof(Index));
        }




    }
}
