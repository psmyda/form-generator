using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace formsGeneratorWS.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}