using sparkRestro.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sparkRestro.Api.Services
{
    public interface IRestaurantRepository
    {
        IEnumerable<Food> GetFoods();
        Food GetFood(int foodId);
    }
}
