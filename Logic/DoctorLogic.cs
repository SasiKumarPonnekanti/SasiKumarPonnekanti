using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Models;

namespace ConsoleApp2.Logic
{
    internal class DoctorLogic : StaffLogic
    {
        public override void create (Staff doctor)
        {

        }
        public override void Update(Staff doctor,int id)
        {

        }
        public override void Delete(int id)
        {

        }
        public override List<Staff> getall()
        {
            return null;
        }
        public override Staff GetbyId(int id)
        {
            return null;
        }
        public override int GetGroddIncome(Staff s)
        {
            Console.WriteLine("Get Doctor GroddIncome");
            return 0;
        }

        public override int GetNetIncome(Staff s)
        {
            Console.WriteLine("Get Doctor NetIncome");
            return 0;
        }

        public override int GetTax(Staff s)
        {
            Console.WriteLine("Get Doctor Tax");
            return 0;
        }
    }
}
