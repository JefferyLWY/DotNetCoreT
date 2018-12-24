using OdeToVeggie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToVeggie.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> _resturants;

        public InMemoryRestaurantData()
        {
            _resturants = new List<Restaurant> {
                new Restaurant {Id = 1, Name = "Scott's Pizza"},
                new Restaurant {Id = 2, Name = "Bruce's Bar"},
                new Restaurant {Id = 3, Name = "Jack's Place"}
            };
        }

        public Restaurant Add(Restaurant restaurant)
        {
            restaurant.Id = _resturants.Max(r => r.Id) + 1;
            _resturants.Add(restaurant);
            return restaurant;
        }

        public Restaurant Get(int Id)
        {
            return _resturants.FirstOrDefault(r => r.Id == Id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _resturants.OrderBy(r => r.Name);
        }

    }
}
