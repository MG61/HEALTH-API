using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Health.Models
{
    public class Provider
    {
        [Key]
        public int ID_provider { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string Логин { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Пароль { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Фамилия { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Имя { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Отчество { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Склад { get; set; }
    }
}
