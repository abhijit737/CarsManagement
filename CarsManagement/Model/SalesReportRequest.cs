namespace CarsManagement.Models
{
    using System.ComponentModel.DataAnnotations;

   
        public class SalesReportRequest
        {
            [Required]
            public string Salesman { get; set; }

            [Required]
            [RegularExpression("^[A-C]$", ErrorMessage = "Car class must be A, B, or C.")]
            public string CarClass { get; set; }

            [Required]
            [Range(0, int.MaxValue, ErrorMessage = "Number of Cars Sold for Audi must be a non-negative integer.")]
            public int AudiSold { get; set; }

            [Required]
            [Range(0, int.MaxValue, ErrorMessage = "Number of Cars Sold for Jaguar must be a non-negative integer.")]
            public int JaguarSold { get; set; }

            [Required]
            [Range(0, int.MaxValue, ErrorMessage = "Number of Cars Sold for Land Rover must be a non-negative integer.")]
            public int LandRoverSold { get; set; }

            [Required]
            [Range(0, int.MaxValue, ErrorMessage = "Number of Cars Sold for Renault must be a non-negative integer.")]
            public int RenaultSold { get; set; }

        }
    }


