

using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public  DateTime Orderdate { get; set; }
        public string Category { get; set; } = string.Empty;
        public string Shelf { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Count must be 0 or greater")]
        public int Count { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}

