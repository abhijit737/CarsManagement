using CarsManagement.DTOs;
using CarsManagement.Models;
using CarsManagement.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarsManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesReportController : ControllerBase
    {
        private readonly ISalesReportService _salesReportService;

        public SalesReportController(ISalesReportService salesReportService)
        {
            _salesReportService = salesReportService;
        }

        [HttpPost]
        public IActionResult GenerateReport([FromBody] SalesReportRequest request)
        {
          if (ModelState.IsValid)
    {
        var reportRequestDto = new SalesReportRequestDto
        {
            Salesman = request.Salesman,
            CarClass = request.CarClass,
            AudiSold = request.AudiSold,
            JaguarSold = request.JaguarSold,
            LandRoverSold = request.LandRoverSold,
            RenaultSold = request.RenaultSold,
          //  PreviousYearSales = request.
        };

        var report = _salesReportService.GenerateSalesReport(reportRequestDto);
        return Ok(report);
    }
    
    return BadRequest("Invalid Data");
        }
    }
}
