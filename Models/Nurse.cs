using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Nurse:Staff
    {
        public int Taxpercentage { get; } = 3;

        public int DressAllowence { get; } = 3000;
        public int incentiveAmount { get; } = 7000;
        public string ReportingTo { get; set; }
    }
}
