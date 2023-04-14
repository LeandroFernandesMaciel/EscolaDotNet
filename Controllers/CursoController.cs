using AplicativoWeb.Models;//camada model 
using Microsoft.AspNetCore.Mvc; //microsoft
namespace AplicativoWeb.Controllers; // Definindo

// criamos a classe Controller 
public class CursoController : Controller
{
    public IActionResult Index()
    {
        Curso c1 = new Curso();
        //set
        c1.Descricao = "Primeiros Passos no ASP.NET";
        c1.TituloInterno = "Desenvolvedor c#";
        c1.TituloMarketing = "Crie Aplicativos Incríveis";

        //get
        ViewData["curso"] = c1;

        return View();
    }
    //action 
    public IActionResult Create(){
        ViewData["titulo"] = "Cadastro de Curso";
        ViewBag.DataHora = DateTime.Now; 
    
        return View();
    }
}
