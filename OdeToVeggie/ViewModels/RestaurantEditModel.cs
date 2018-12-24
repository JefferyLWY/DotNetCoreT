using OdeToVeggie.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToVeggie.ViewModels
{
    public class RestaurantEditModel
    {
        [Required, MaxLength(60)]
        public string Name { get; set; }
        public CuisineType cuisine { get; set; }
    }
}
