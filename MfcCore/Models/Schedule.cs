using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MfcCore.Models
{
    public class Schedule
    {
        public int ID { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
    }
}
