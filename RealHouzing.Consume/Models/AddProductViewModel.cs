namespace RealHouzing.Consume.Models
{
    public class AddProductViewModel
    {
        public string ProductTitle { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductType { get; set; }
        public string ProductAddress { get; set; }
        public int BedroomCount { get; set; }
        public int BathCount { get; set; }
        public int Square { get; set; }
        public string ImageURL { get; set; }
        public int CategoryID { get; set; }
    }
}
