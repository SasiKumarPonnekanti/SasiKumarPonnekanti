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

        public void createwithDict(Staff doctor)
        {
            staffDictionary.Add(doctor.StaffId, doctor);
        }

        public void UpdateDict(Staff doctor,int id)
        {
            staffDictionary[id].Email = doctor.Email;
            //other properties
        }

        public void DeleteWithDict(int id)
        {
            staffDictionary.Remove(id);
        }
        public Staff GetByid(int id)
        {
            return staffDictionary[id];
        }
        public List<Staff> GetAll()
        {
            List<Staff> doctors = new List<Staff>();
            foreach(KeyValuePair<int,Staff> kvp in staffDictionary)
            {
                if(kvp.Value.GetType()== typeof(Doctor))
                {
                    doctors.Add(kvp.Value);
                }
            }
            return doctors;
        }
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
