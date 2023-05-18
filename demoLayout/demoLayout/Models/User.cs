using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demoLayout.Models
{
    public class User
    {
        public long Id { get; set; }
        [DisplayName("Tên người dùng")]
        public string? name { get; set; }
        [DisplayName("Địa chỉ")]
        public string? address { get; set; }
        [DisplayName("Email")]
        public string? email { get; set; }
    }
}
