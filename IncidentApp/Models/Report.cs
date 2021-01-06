using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Report
    {
        [Key]
        public int Report_ID { get; set; }
        public virtual User_Account Report_Request { get; set; }
        public string Report_Description { get; set; }
    }
}
