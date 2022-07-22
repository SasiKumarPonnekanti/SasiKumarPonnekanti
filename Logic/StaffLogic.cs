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
        public List<Staff> staff = new List<Staff>();
        public abstract void create();

        public abstract void Update();
        
        public abstract void Delete();
        
        public abstract void getall();

         public abstract void GetbyId();
        
       
        public abstract int GetGroddIncome(Staff s);
        public abstract int GetTax(Staff s);
        public abstract int GetNetIncome(Staff s);
    }
}
