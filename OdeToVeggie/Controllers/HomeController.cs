using Microsoft.AspNetCore.Mvc;
using OdeToVeggie.Models;
using OdeToVeggie.Services;

namespace OdeToVeggie.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;

        public HomeController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }

        public IActionResult Index()
        {
            var model = _restaurantData.GetAll();

            return View(model);
        }
    }
}
