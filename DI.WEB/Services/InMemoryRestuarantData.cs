using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DI.WEB.Models;

namespace DI.WEB.Services
{
    public class InMemoryRestuarantData : IRestuarant
    {
        List<Restaurant> restaurants;
        public InMemoryRestuarantData()
        {
            restaurants = new List<Restaurant>() {
                new Restaurant {Id =1 , Name="Mother India", Cuisine=CuisineType.Indian },
                new Restaurant {Id =2 , Name="Italian Food", Cuisine=CuisineType.Italian},
                new Restaurant {Id =1 , Name="French Toast", Cuisine=CuisineType.French }
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}
