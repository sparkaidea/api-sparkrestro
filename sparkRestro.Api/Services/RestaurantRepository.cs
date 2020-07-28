using sparkRestro.Api.DbContexts;
using sparkRestro.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sparkRestro.Api.Services
{
    public class RestaurantRepository : IRestaurantRepository, IDisposable
    {
        private readonly CourseLibraryContext _context;

        public RestaurantRepository(CourseLibraryContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Food> GetFoods()
        {
            return _context.Foods.ToList<Food>();
        }

        public Food GetFood(int foodId)
        {
            if (foodId == 0)
            {
                throw new ArgumentNullException(nameof(foodId));
            }

            return _context.Foods.FirstOrDefault(a => a.Id == foodId);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                // dispose resources when needed
            }
        }

        
    }
}
