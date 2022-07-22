using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Models;

namespace ConsoleApp2.Logic
{
    internal class TechnicianLogic : StaffLogic
    {
        public void create()
        {

        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
        public void getall()
        {

        }
        public void GetbyId()
        {

        }
        public override int GetGroddIncome(Staff s)
        {
            Console.WriteLine("Get Technician GroddIncome");
            return 0;
        }

        public override int GetNetIncome(Staff s)
        {
            Console.WriteLine("Get Technician income");
            return 0;
        }

        public override int GetTax(Staff s)
        {
            Console.WriteLine("Get Technician Tax");
            return 0;
        }
    }
}
