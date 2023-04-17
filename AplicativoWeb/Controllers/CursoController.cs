using AplicativoWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicativoWeb.Controllers;
public class CursoController:Controller{
    
    public IActionResult Index(){
        Curso C1 = new Curso();

        //SET==INSERIU
        C1.Descricao = "Primeiros Passos no ASP.NET CORE";
        C1.TituloInterno = "Desenvolvedor C#";
        C1.TituloMarketing = "DotNet do Zero";

        //GET==CHAMOU
        ViewData["Curso"] = C1;
        
    



        return View();
    }

    public IActionResult Create(){
        ViewData["titulo"] = "Cadastro de Cursos";
        ViewBag.DataHora = DateTime.Now;
    
        return View();
    }
     
    
}