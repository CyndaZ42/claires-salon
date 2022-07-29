using Microsoft.AspNetCore.Mvc;

namespace HairSalon.controller
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}