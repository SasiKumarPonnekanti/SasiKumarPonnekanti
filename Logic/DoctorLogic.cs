using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Logic
{
    internal class DoctorLogic : StaffLogic
    {
        public override int GetGroddIncome()
        {
            Console.WriteLine("Get Doctor GroddIncome");
            return 0;
        }

        public override int GetNetIncome()
        {
            Console.WriteLine("Get Doctor NetIncome");
            return 0;
        }

        public override int GetTax()
        {
            Console.WriteLine("Get Doctor Tax");
            return 0;
        }
    }
}
