using Microsoft.AspNetCore.Mvc;
using OdeToVeggie.Models;
using OdeToVeggie.Services;
using OdeToVeggie.ViewModels;

namespace OdeToVeggie.Controllers
{
    public class HomeController : Controller
    {
        private IRestaurantData _restaurantData;
        private IGreeter _greeter;

        public HomeController(IRestaurantData restaurantData, IGreeter greeter)
        {
            _restaurantData = restaurantData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeViewModel();
            model.Restaurants = _restaurantData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();

            return View(model);
        }

        public IActionResult Details(int Id)
        {
            var model = _restaurantData.Get(Id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
    }
}
