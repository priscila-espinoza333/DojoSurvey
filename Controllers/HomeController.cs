using Microsoft.AspNetCore.Mvc;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            string titulo = "Bienvenido a Dojo Survey";
            ViewBag.Titulo = titulo;
            return View("Index");
        }

        [HttpGet("formulario")]
        public IActionResult Formulario (){
            return View("Formulario");
        }

        [HttpGet("gobackform")]
        public RedirectResult GoBackForm(){
            return Redirect("/formulario");
        }

        [HttpGet]
        [Route("procesa/formulario")]
        public RedirectResult ProcesaFormulario(){
            return Redirect ("/formulario");
        }

        public class DatosFormulario{
        public string? Nombre { get; set; }
        public string? Locacion { get; set; }
        public string? LenguajeFavorito { get; set; }
        public string? Comentario { get; set; }
        }

        [HttpPost]
        [Route("info/formulario")]
        public IActionResult  ProcesaFormulario(DatosFormulario model){
            string nombre = model.Nombre;
            string locacion = model.Locacion;
            string lenguajeFavorito = model.LenguajeFavorito;
            string comentario = model.Comentario;

            ViewBag.Nombre = nombre;
            ViewBag.Locacion = locacion;
            ViewBag.LenguajeFavorito = lenguajeFavorito;
            ViewBag.Comentario = comentario;

            return View("Result");
        }

    }
}
