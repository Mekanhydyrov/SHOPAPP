using System.ComponentModel.DataAnnotations;

namespace shopapp.webui.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required]
        [StringLength(60,MinimumLength =5, ErrorMessage ="Ürün Ýsmi 5-60 Karakter Aralýðýnda Olmalýdýr!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Fiyat Girmelisiniz!")]
        [Range(1,100000)]
        public double? Price { get; set; } 
        public string Description { get; set; } 
        [Required]
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }
        [Required]
        public int? CategoryId { get; set; }
    }
}