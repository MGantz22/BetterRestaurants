using Microsoft.AspNetCore.Mvc;
using BetterRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
namespace BetterRestaurants.Controllers;

public class HomeController : Controller
{

  [Route("/")]
  public ActionResult Index() 
  {
    return View();
  }

}

