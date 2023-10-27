using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectSWT.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Vui lòng nhập tên tài khoản!")]
        public string username { get; set; }

        [Required(ErrorMessage ="Vui lòng nhập mật khẩu!")]
        public string password { get; set; }     
        
        public bool rememberme { get; set; }
    }
}