using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Logic
{
    internal class NurseLogic : StaffLogic
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
            Console.WriteLine("Get Nurse GroddIncome");
            return 0;
        }

        public override int GetNetIncome(Staff s)
        {
            Console.WriteLine("Get Nurse NetIncome");
            return 0;
        }

        public override int GetTax(Staff s)
        {
            Console.WriteLine("Get Nurse Tax");
            return 0;
        }
    }
}
