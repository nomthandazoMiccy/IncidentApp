using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Task_Detail
    {
        [Key]
        public int Task_ID { get; set; }
        public virtual Status Task_Status { get; set; }
        public string? Task_Reason { get; set; }
        public virtual Incident Incident { get; set; }
        public virtual User_Account? Technician { get; set; }
    }
}
