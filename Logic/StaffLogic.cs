using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Models;

namespace ConsoleApp2.Logic
{
    public abstract class StaffLogic
    {
        public  List<Staff> staff = new List<Staff>();
        public abstract int GetGroddIncome();
        public abstract int GetTax();
        public abstract int GetNetIncome();
    }
}
