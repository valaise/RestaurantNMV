using Microsoft.AspNetCore.Mvc;
using RestaurantNMV.Models;

namespace RestaurantNMV.Controllers
{
    public class DishesController
    {
        public class DishesController : Controller
        {
            [Route("api/[controller]")]
            public class DishesController : Controller
            {
                [HttpGet]
                public IEnumerable<Dish> Get()
                {
                    return new[]
{
                        new Dish
                        {
                            Name ="Erste Name",
                            Description = "meine test zum Bescchreiben",
                            Id = 1,
                            Price = 3.99
                        }
                    };
}
            }
        }
    }
}
