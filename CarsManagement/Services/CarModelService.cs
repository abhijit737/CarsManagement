using CarsManagement.DTOs;
using CarsManagement.Model;
using Microsoft.Data.Sql;
using System.Collections.Generic;
using Dapper;
namespace CarsManagement.Services
   

{
    public class CarModelService : ICarModelService
    {
        private readonly DapperDbContext _dbContext;

        public CarModelService(DapperDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<CarModel> GetAllCarModels()
        {
            using (var connection = _dbContext.CreateConnection())
            {
                string sql = "SELECT * FROM CarModels ORDER BY SortOrder ASC";
                return connection.Query<CarModel>(sql).ToList();
            }
        }

        public CarModel GetCarModelById(int id)
        {
            using (var connection = _dbContext.CreateConnection())
            {
                string sql = "SELECT * FROM CarModels WHERE Id = @Id";
                return connection.QuerySingleOrDefault<CarModel>(sql, new { Id = id });
            }
        }

        public void AddCarModel(CarModelDto carModelDto)
        {
            using (var connection = _dbContext.CreateConnection())
            {
                string sql = @"INSERT INTO CarModels 
                           (Brand, Class, ModelName, ModelCode, Description, Features, Price, DateOfManufacturing, Active, SortOrder, Images) 
                           VALUES (@Brand, @Class, @ModelName, @ModelCode, @Description, @Features, @Price, @DateOfManufacturing, @Active, @SortOrder, @Images)";
                connection.Execute(sql, new { carModelDto.Brand, carModelDto.Class, carModelDto.ModelName, carModelDto.ModelCode, carModelDto.Description, carModelDto.Features, carModelDto.Price, carModelDto.DateOfManufacturing, carModelDto.Active, carModelDto.SortOrder, carModelDto.Images });

            }
        }

        public void UpdateCarModel(int id, CarModelDto carModelDto)
        {
            using (var connection = _dbContext.CreateConnection())
            {
                string sql = @"UPDATE CarModels SET 
                           Brand = @Brand, Class = @Class, ModelName = @ModelName, ModelCode = @ModelCode, 
                           Description = @Description, Features = @Features, Price = @Price, 
                           DateOfManufacturing = @DateOfManufacturing, Active = @Active, SortOrder = @SortOrder, 
                           Images = @Images WHERE Id = @Id";
                connection.Execute(sql, new { carModelDto.Brand, carModelDto.Class, carModelDto.ModelName, carModelDto.ModelCode, carModelDto.Description, carModelDto.Features, carModelDto.Price, carModelDto.DateOfManufacturing, carModelDto.Active, carModelDto.SortOrder, carModelDto.Images, Id = id });
            }
        }

        public void DeleteCarModel(int id)
        {
            using (var connection = _dbContext.CreateConnection())
            {
                string sql = "DELETE FROM CarModels WHERE Id = @Id";
                connection.Execute(sql, new { Id = id });
            }
        }
    }
}
