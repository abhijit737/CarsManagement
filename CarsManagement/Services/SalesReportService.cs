using CarsManagement.DTOs;
using CarsManagement.Model;
using Dapper;
namespace CarsManagement.Services
{
    public class SalesReportService:ISalesReportService
    {
        private readonly DapperDbContext _dbContext;

        public SalesReportService(DapperDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public SalesReport GenerateSalesReport(SalesReportRequestDto request)
        {
            // Example logic for calculating commissions based on the sales data
            var report = new SalesReport
            {
                Salesman = request.Salesman,
                CarClass = request.CarClass,
                AudiSold = request.AudiSold,
                JaguarSold = request.JaguarSold,
                LandRoverSold = request.LandRoverSold,
                RenaultSold = request.RenaultSold,
            };

            // Apply fixed and additional commission logic based on the car brand and class
            report.Commission = CalculateCommission(report);

            return report;
        }

        public IEnumerable<SalesReport> GetSalesReports()
        {
            using (var connection = _dbContext.CreateConnection())
            {
                string sql = "SELECT * FROM SalesReports";
                return connection.Query<SalesReport>(sql).ToList();
            }
        }

        private decimal CalculateCommission(SalesReport report)
        {
            decimal commission = 0;
            // Commission logic based on car brand, class, and number of cars sold
            if (report.CarClass == "A")
            {
                commission += report.AudiSold * 800 + report.JaguarSold * 750 + report.LandRoverSold * 850 + report.RenaultSold * 400;
                // Additional class-based commission
                commission += report.AudiSold * 0.08m * report.AudiSold + report.JaguarSold * 0.06m * report.JaguarSold;
            }
            else if (report.CarClass == "B")
            {
                commission += report.AudiSold * 0.06m * report.AudiSold + report.JaguarSold * 0.05m * report.JaguarSold;
            }
           

            return commission;
        }
    }
}
