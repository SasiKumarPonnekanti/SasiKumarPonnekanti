using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Nurse:Staff
    {
        public string Taxpercentage { get; set; }   

        public string ReportingTo { get; set; }
    }
}
