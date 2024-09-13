using CarsManagement.Model;
using CarsManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CarsManagement.DTOs;
namespace CarsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarModelsController : ControllerBase
    {
        private readonly ICarModelService _carModelService;

        public CarModelsController(ICarModelService carModelService)
        {
            _carModelService = carModelService;
        }

        [HttpGet]
        public IActionResult GetAllCarModels()
        {
            var models = _carModelService.GetAllCarModels();
            return Ok(models);
        }

        [HttpPost]
        public IActionResult AddCarModel([FromBody] CarModel carModel)
        {
            if (ModelState.IsValid)
            {
                var carModelDto = new CarModelDto
                {
                    Brand = carModel.Brand,
                    Class = carModel.Class,
                    ModelName = carModel.ModelName,
                    ModelCode = carModel.ModelCode,
                    Description = carModel.Description,
                    Features = carModel.Features,
                    Price = carModel.Price,
                    DateOfManufacturing = carModel.DateOfManufacturing,
                    Active = carModel.Active,
                    SortOrder = carModel.SortOrder,
                    Images = carModel.Images
                };
                _carModelService.AddCarModel(carModelDto);
                return Ok("Car Model Added Successfully");
            }
            return BadRequest("Invalid Data");
        }

    }
} 
