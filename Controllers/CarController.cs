using System.Net;
using Microsoft.AspNetCore.Mvc;
using CarAPI.Interfaces; 
using CarAPI.Models;     
using CarAPI.Data;

namespace CarAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CarController : Controller
    {
        private readonly ICarRepository _carRepository;
        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }

        //Visualização
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<Car>))]
        
        public IActionResult GetCars() //Do Repository/PokemonRepository.cs
        {
            var cars = _carRepository.GetCars;

            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(cars);
        }
    }
}