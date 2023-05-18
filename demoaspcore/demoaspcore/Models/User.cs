using System.ComponentModel.DataAnnotations;

namespace demoaspcore.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Phải nhập trường này")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Phải nhập trường này")]
        public string? PassWord { get; set; }
    }
}
