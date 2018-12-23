using Microsoft.AspNetCore.Mvc;

namespace OdeToVeggie.Controllers
{
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
        public string Phone()
        {
            return "6666 6666";
        }

        public string Address()
        {
            return "Singapore";
        }
    }
}
