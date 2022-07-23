using CarAPI.Data;
using CarAPI.Models;
using CarAPI.Interfaces;

namespace CarAPI.Repository
{
    public class CarRepository : ICarRepository
    {
        private readonly DataContext _context;

        public CarRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<Car> GetCars()
        {
            return _context.Cars.OrderBy(p => p.Id).ToList(); 
        }
    }
}