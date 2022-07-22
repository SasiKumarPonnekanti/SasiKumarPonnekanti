using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Logic
{
    internal class NurseLogic : StaffLogic
    {
        
        public override int GetGroddIncome()
        {
            Console.WriteLine("Get Nurse GroddIncome");
            return 0;
        }

        public override int GetNetIncome()
        {
            Console.WriteLine("Get Nurse NetIncome");
            return 0;
        }

        public override int GetTax()
        {
            Console.WriteLine("Get Nurse Tax");
            return 0;
        }
    }
}
