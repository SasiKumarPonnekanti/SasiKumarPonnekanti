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
       public int TaxPercentage { get; } 
    }
}
