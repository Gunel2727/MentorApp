using System.ComponentModel.DataAnnotations.Schema;

namespace EternaApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public string ShortDescription=> Description.Length > 20 ? Description.Substring(0, 20) + "..." : Description;
        public string Client { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }
        public int CategoryId { get; set; }
        public Categories Category { get; set; }
        public List<ProductImage> ProductImages { get; set; }
    }
}
