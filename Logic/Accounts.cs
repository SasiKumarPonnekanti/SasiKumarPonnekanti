using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Logic
{
    public class Accounts
    {
        public double CalculateIncome(StaffLogic staffLogic,Staff s)
        {
            return staffLogic.GetNetIncome(s);
        }
    }
}
