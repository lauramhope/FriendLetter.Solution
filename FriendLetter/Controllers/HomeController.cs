using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller // we tell our program HomeController should inherit functionality from Controller Class
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye friend."; }

    [Route("/")]
    public ActionResult Letter() { return View(); } // ActionResult is a built-in MVC class that handles rendering views, and View() is a built-in method that locates the view file associated with the controller action. In this case, the view file is Views/Home/Letter.cshtml.

  }
}