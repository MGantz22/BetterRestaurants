using Microsoft.AspNetCore.Mvc;
using BetterRestaurants.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace BetterRestaurants.Controllers;

public class RestaurantsController : Controller
{
  private readonly BetterRestaurantContext _db;
  
  public RestaurantsController(BetterRestaurantContext db)
  {
    _db = db;
  }
}