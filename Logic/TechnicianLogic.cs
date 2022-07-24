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
       
        public override void create(Staff technician)
        {
            staffList.Add(technician);
        }
        public override void Update(Staff technician,int id)
        {
            foreach(Staff item in staffList)
            {
                if (item.StaffId == id)
                {
                    item.StaffName = technician.StaffName;
                    item.ContactNo = technician.ContactNo;
                    //Complte for remaining Propertires
                }
            }
        }
        public override void Delete(int id)
        {
            foreach (Staff item in staffList)
            {
                if (item.StaffId == id)
                {
                    staffList.Remove(item);
                }
            }

        }
        public override List<Staff> getall()
        {
            List<Staff> technicianList = new List<Staff>();
            foreach(Staff item in staffList)
            {
                if(item.GetType() == typeof(Technician))
                {
                    technicianList.Add(item);
                }
            }
            return technicianList;
        }
        public override Staff GetbyId(int id)
        {
            foreach (Staff item in staffList)
            {
                if (item.StaffId == id&&item.GetType()==typeof(Technician))
                {
                    return item;
                }
            }
            return null;

        }
        public new int GetGroddIncome(Staff s)
        {
            Console.WriteLine("Get Technician GroddIncome");
            return 0;
        }

        public override int GetNetIncome(Staff s)
        {
            Console.WriteLine("Get Technician income");
            return 0;
        }

        public new int GetTax(Staff s)
        {
            Console.WriteLine("Get Technician Tax");
            return 0;
        }
    }
}
