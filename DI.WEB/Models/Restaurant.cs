using System;
using System.Collections.Generic;
using System.Text;

namespace DI.WEB.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
    }
}
