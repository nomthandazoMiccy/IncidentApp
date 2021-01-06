﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Incident
    {
        [Key]
        public int Id { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime Date_Logged { get; set; }
        public virtual Status status { get; set; }
        public virtual User_Account user { get; set; }
        public virtual User_Account? technician { get; set; }
    }
}
