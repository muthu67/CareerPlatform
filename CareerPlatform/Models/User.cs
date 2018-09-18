using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CareerPlatform.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public long Telephone { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
    }
}