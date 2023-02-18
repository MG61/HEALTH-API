using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Health.Models
{
    public class ShoppingCart
    {
        [Key]
        public int ID_cart { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Название { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Количество { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Цена { get; set; }
    }
}
