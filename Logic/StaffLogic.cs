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
        public static List<Staff> staffList = new List<Staff>();
        public abstract void create(Staff staff);

        public abstract void Update(Staff staff,int id);
        
        public abstract void Delete(int id);
        
        public abstract List<Staff> getall();

         public abstract Staff GetbyId(int id);
        
       
        public virtual double GetGroddIncome(Staff s)
        {
            return 1000;
        }
       
        public virtual double GetTax(Staff s)
        {
            return 1000;
        }
        public abstract double GetNetIncome(Staff s);
       
    }
}
