﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MfcCore.Models
{
    public class Schedule
    {
        public int ID { get; set; }
        public string Location { get; set; }
        [DisplayFormat(DataFormatString = "{0:MM-dd}")]
        public DateTime Date { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
    }
}
