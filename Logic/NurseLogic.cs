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
        public override void create(Staff nurse)
        {
            staffList.Add(nurse);
        }
        public override void Update(Staff nurse,int id)
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

        public override double GetGroddIncome(Staff s)
        {
            Nurse nurse = (Nurse)s;
            return (nurse.BasicPay + nurse.DressAllowence + nurse.incentiveAmount) * 12; 
        }

        public override double GetNetIncome(Staff s)
        {
            Nurse nurse = (Nurse)s;
            return ((nurse.BasicPay + nurse.DressAllowence + nurse.incentiveAmount) * 12)-(nurse.BasicPay*12*nurse.Taxpercentage);
        }

        public override double GetTax(Staff s)
        {
            Nurse nurse = (Nurse)s;
            return nurse.BasicPay * 12 * nurse.Taxpercentage;
            
        }
    }
}
