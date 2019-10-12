using DI.WEB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DI.WEB.Services
{
    public interface IRestuarant
    {
        IEnumerable<Restaurant> GetAll();
    }
}
