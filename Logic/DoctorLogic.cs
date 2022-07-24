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
            staffList.Add(doctor);
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
        public override double GetGroddIncome(Staff s)
        {
            Doctor doctor = (Doctor)s;
            return ((doctor.BasicPay + doctor.incentiveAmount) * 12) + doctor.ResearchPay;
            
        }

        public override double GetNetIncome(Staff s)
        {
            Doctor doctor = (Doctor)s;
            return (((doctor.BasicPay + doctor.incentiveAmount) * 12) + doctor.ResearchPay)-(doctor.BasicPay*doctor.taxPercentage*0.01);
           
        }

        public override double GetTax(Staff s)
        {
            Doctor doctor = (Doctor)s;
            return (doctor.BasicPay * doctor.taxPercentage * 0.01);
        }
    }
}
