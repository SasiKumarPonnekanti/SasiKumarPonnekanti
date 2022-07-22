using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Logic
{
    public class Accounts
    {
        public int CalculateIncome(StaffLogic staffLogic)
        {
            return staffLogic.GetNetIncome();
        }
    }
}
