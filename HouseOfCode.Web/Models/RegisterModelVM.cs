using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HouseOfCode.Web.Models
{
    public class RegisterModelVM
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Repassword { get; set; }

        public bool isModelValid()
        {
            if (Password == Repassword && Name != "" && Email != "")
                return true;
            else
                return false;
        }
    }
}