using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace demoLayout.Models
{
    public class Login
    {
        [DisplayName("Tên người dùng:")]
        public string? userName { get; set; }
        [DataType(DataType.Password)]

        [DisplayName("Mật khẩu:")]
        public string? password { get; set; }
    }
}
