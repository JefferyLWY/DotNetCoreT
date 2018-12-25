using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToVeggie.Data;
using OdeToVeggie.Models;

namespace OdeToVeggie.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private OdeToVeggieDbContext _context;

        public SqlRestaurantData(OdeToVeggieDbContext context)
        {
            _context = context;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int Id)
        {
            return _context.Restaurants.FirstOrDefault(r => r.Id == Id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants;
        }
    }
}
