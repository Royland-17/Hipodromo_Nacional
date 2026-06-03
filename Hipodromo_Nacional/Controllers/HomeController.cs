using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace Hipodromo_Nacional.Controllers;

[Authorize]
public class HomeController : Controller
{
    public IActionResult Index() => View();
}
