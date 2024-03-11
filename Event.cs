using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventManagment
{
    public class Event
    {
        public int EventID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Capacity { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}