namespace CarsManagement.Model
{
    public class SalesReport
    {
        public string Salesman { get; set; }
        public string CarClass { get; set; }
        public int AudiSold { get; set; }
        public int JaguarSold { get; set; }
        public int LandRoverSold { get; set; }
        public int RenaultSold { get; set; }
        public decimal Commission { get; set; }
    }
}
