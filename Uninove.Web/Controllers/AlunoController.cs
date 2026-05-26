using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninovr.Web.Models;

namespace Uninove.Web.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Henrique";
        ViewBag.curso = "Análise de Sistemas";
        ViewBag.Semestre = 1;

        return View();
    }
}