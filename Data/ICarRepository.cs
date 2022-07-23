using CarAPI.Models;

namespace CarAPI.Interfaces
{
    public interface ICarRepository
    {
        //Visualização
        ICollection<Car> GetCars();
    }
}