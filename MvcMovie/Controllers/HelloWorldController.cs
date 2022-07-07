using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Welcome(string nome, int vezes = 1, int ID = 1)
        {

            return HtmlEncoder.Default.Encode($"oi {nome}, vezes: {vezes}. ID: {ID}");
        }
        public string Teste()
        {
            return "aqui é só pra mostrar como funciona a relação rota x método dentro da controller";
        }
    }
}
