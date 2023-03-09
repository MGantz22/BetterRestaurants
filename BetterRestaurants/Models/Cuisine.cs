using System;
using System.Collections.Generic;
namespace BetterRestaurants.Models;

public class Cuisine
{
  public int CuisineId {get;set;}
  public string CuisineType {get;set;}
  public List<Restaurant> Restaurants {get;set;} 
}