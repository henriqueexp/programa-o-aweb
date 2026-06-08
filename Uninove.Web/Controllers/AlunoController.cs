using Microsoft.AspNetCore.Mvc;

namespace Uninove.Web.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Henrique Moraes Expedito";
        ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
        ViewBag.Semestre = "1º Semestre";

        return View();
    }

    public IActionResult Detalhes(int id)
    {
        ViewBag.Id = id;
        return View();
    }
}