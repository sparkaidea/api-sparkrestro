using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using sparkRestro.Api.Services;

namespace sparkRestro.Api.Controllers
{
    [ApiController]
    [Route("api/restaurants")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantController(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository ??
                throw new ArgumentNullException(nameof(restaurantRepository));
        }

        [HttpGet()]
        public IActionResult GetFoods()
        {
            var foodsFromRepo = _restaurantRepository.GetFoods();
            return Ok(foodsFromRepo);
        }

        [HttpGet("{foodId}")]

        public IActionResult GetFoods(int foodId)
        {
            var authorFromRepo = _restaurantRepository.GetFood(foodId);

            if (authorFromRepo == null)
            {
                return NotFound();
            }

            return Ok(authorFromRepo);
        }
    }
}
