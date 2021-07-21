using Microsoft.AspNetCore.Mvc;
using PlacesYouBeen.Models;
using System.Collections.Generic;

namespace PlacesYouBeen.Controllers
{

  public class PlacesController : Controller //this is the folder name it calls
  {
    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Place> allplaces = Place.GetAll();
      return View(allplaces);
    }
    
    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityName, string picture)
    {
      Place myPlace = new Place(cityName, picture);
      return RedirectToAction("Index");
    }
  }
}