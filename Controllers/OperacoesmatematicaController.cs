using Microsoft.AspNetCore.Mvc;

namespace MvcIntroViews.Controllers;

public class OperacoesMatematicasController : Controller
{

     public IActionResult Somar()
    {
        return View();
    }

}

public IActionResult ResultadoSoma([FromFrom] double n1, double n2)
{
    Viewbag.N1 = n1;
    Viewbag.N2 = n2;
    Viewbag Resultado = n1 - n2;
    return View();
}
