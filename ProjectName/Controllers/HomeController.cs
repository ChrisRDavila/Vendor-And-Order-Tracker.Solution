using Microsoft.AspNetCore.Mvc;
using ProjectName.Models;

namespace ProjectName.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    // Notice the changes below!
    public ActionResult File() { return View(); }
  }
}