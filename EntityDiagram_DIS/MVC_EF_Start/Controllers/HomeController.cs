using Microsoft.AspNetCore.Mvc;

namespace EntityDiagram_DIS.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}