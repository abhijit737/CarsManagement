using CarsManagement.DTOs;
using CarsManagement.Model;

namespace CarsManagement.Services
{
    public interface ICarModelService
    {
        IEnumerable<CarModel> GetAllCarModels();
        CarModel GetCarModelById(int id);
        void AddCarModel(CarModelDto carModelDto);
        void UpdateCarModel(int id, CarModelDto carModelDto);
        void DeleteCarModel(int id);
    }
}
