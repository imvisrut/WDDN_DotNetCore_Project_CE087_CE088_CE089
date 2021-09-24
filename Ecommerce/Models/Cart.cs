using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public string UserId { get; set; }

        public int ProductId { get; set; }
    }
}
