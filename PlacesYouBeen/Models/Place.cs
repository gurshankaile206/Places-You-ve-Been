using System;
using System.Collections.Generic;

namespace PlacesYouBeen.Models
{
  public class Place
  {
    public string CityName { get; set; }

    public string Picture { get; set; }
    private static List<Place> _instances = new List<Place> {}; 
    public Place(string cityName, string picture)
    {
      CityName = cityName;
      Picture = picture;
      _instances.Add(this);
    }
    public static List<Place> GetAll()
    {
      return _instances;
    }
  }
}