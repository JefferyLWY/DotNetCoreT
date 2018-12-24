using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OdeToVeggie.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Display(Name="Restaurant Name")]
        [DataType(DataType.Password)]
        [Required, MaxLength(60)]
        public string Name { get; set; }

        [Display(Name = "Type of Cuisine")]
        public CuisineType cuisine { get; set; }
    }
}
