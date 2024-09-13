using CarsManagement.DTOs;
using CarsManagement.Model;

namespace CarsManagement.Services
{
    public interface ISalesReportService
    {
        SalesReport GenerateSalesReport(SalesReportRequestDto request);
        IEnumerable<SalesReport> GetSalesReports();
    }
}
