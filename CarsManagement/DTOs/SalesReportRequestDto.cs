using System.ComponentModel.DataAnnotations;

namespace CarsManagement.DTOs
{
    public class SalesReportRequestDto
    {
        [Required(ErrorMessage = "Salesman is required")]
        [MaxLength(100, ErrorMessage = "Salesman name cannot exceed 100 characters")]
        public string Salesman { get; set; }

        [Required(ErrorMessage = "Car Class is required")]
        [RegularExpression(@"^(A|B|C)$", ErrorMessage = "Car Class must be A, B, or C")]
        public string CarClass { get; set; }

        [Required(ErrorMessage = "Number of Audi cars sold is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Number of cars sold must be a positive number")]
        public int AudiSold { get; set; }

        [Required(ErrorMessage = "Number of Jaguar cars sold is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Number of cars sold must be a positive number")]
        public int JaguarSold { get; set; }

        [Required(ErrorMessage = "Number of Land Rover cars sold is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Number of cars sold must be a positive number")]
        public int LandRoverSold { get; set; }

        [Required(ErrorMessage = "Number of Renault cars sold is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Number of cars sold must be a positive number")]
        public int RenaultSold { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Previous year sales must be a positive number")]
        public decimal PreviousYearSales { get; set; }
    }
}
