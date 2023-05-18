using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class User
    {

        [Required(ErrorMessage = "Hello")]

        public string name { get; set; }

        [Required(ErrorMessage = "Hi")]
        
        public string password { get; set; }
        public string content { get; set; }
    }
}