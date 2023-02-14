using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Health.Models
{
    public class Client 
    {
        [Key]
        public int ID_client { get; set; }

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
    }
}
