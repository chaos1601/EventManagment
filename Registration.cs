using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagment
{
    public class Registration
    {
        public int RegistrationID { get; set; }
        public int EventID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Status { get; set; }
    }
}