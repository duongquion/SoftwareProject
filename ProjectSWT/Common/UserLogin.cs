using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectSWT.Common
{
    [Serializable]
    public class UserLogin
    {
        public long UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }           
    }
}