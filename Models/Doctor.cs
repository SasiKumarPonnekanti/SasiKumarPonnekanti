using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public class Doctor:Staff
    {
        public string? Specialization { get; set; }
        public int Fees { get; set; }
        public int MaxPatientsPerDay { get; set; }
    }
}
