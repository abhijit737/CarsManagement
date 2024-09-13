using System.ComponentModel.DataAnnotations;

namespace CarsManagement.DTOs
{
    public class CarModelDto
    {
        [Required(ErrorMessage = "Brand is required")]
        public string Brand { get; set; }

        [Required(ErrorMessage = "Class is required")]
        public string Class { get; set; }

        [Required(ErrorMessage = "Model Name is required")]
        [MaxLength(50, ErrorMessage = "Model Name cannot be longer than 50 characters")]
        public string ModelName { get; set; }

        [Required(ErrorMessage = "Model Code is required")]
        [RegularExpression(@"^[a-zA-Z0-9]{10}$", ErrorMessage = "Model Code must be exactly 10 alphanumeric characters")]
        public string ModelCode { get; set; }

        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Features are required")]
        public string Features { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Date of Manufacturing is required")]
        public DateTime DateOfManufacturing { get; set; }

        public bool Active { get; set; }

        [Required(ErrorMessage = "Sort order is required")]
        public int SortOrder { get; set; }

        [Required(ErrorMessage = "At least one image is required")]
        [MaxLength(5 * 1024 * 1024, ErrorMessage = "Each image must be less than 5MB")] 
        public List<string> Images { get; set; }


    }
}
