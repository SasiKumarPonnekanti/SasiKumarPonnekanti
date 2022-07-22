using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Logic
{
    internal class TechnicianLogic : StaffLogic
    {
        public override int GetGroddIncome()
        {
            Console.WriteLine("Get Technician GroddTax");
            return 0;
        }

        public override int GetNetIncome()
        {
            Console.WriteLine("Get Technician income");
            return 0;
        }

        public override int GetTax()
        {
            Console.WriteLine("Get Technician Tax");
            return 0;
        }
    }
}
