using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Technician:Staff
    {
        public string MachineName { get; set; }

        public int RepairFee { get; set; }  
        public int incentiveAmount { get; } = 3000;
        public int TaxPercentage { get; } = 2; 
    }
}
