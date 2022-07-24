using ConsoleApp2.Models;
using ConsoleApp2.Logic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Staff nandu = new Staff() { StaffName="NanduStaff"};
Staff sasi = new Doctor() { StaffName="SasiDoctor"};
Staff naveen = new Technician() { StaffName="naveenTech"};
Staff Ravi = new Nurse() { StaffName="raviNurse"};
Staff brahma = new Doctor() { StaffName = "brahmaDoctor" };
Staff Harish = new Technician() { StaffName = "HarishTech" };
Staff Sai = new Nurse() { StaffName = "SaiNurse" };


   
StaffLogic doctorLogic = new DoctorLogic();
StaffLogic nurseLogic = new NurseLogic();
StaffLogic technicianLogic = new TechnicianLogic();
doctorLogic.create(sasi);
technicianLogic.create(naveen);
nurseLogic.create(Ravi);
doctorLogic.create(brahma);
technicianLogic.create(Harish);
nurseLogic.create(Sai);
StaffLogic.staffList.Add(nandu);
foreach(Staff s in StaffLogic.staffList)
{
    Console.WriteLine(s.StaffName);
}


//To Search Employee using name 
Console.WriteLine("Enter Name To Search");
string nameToSearch = Console.ReadLine();
int count = 0;
foreach(Staff s in StaffLogic.staffList)
{
    
    if(s.StaffName== nameToSearch)
    {
        Console.WriteLine($"{s.StaffName} {s.Email}");
       count++;
    }
    
}
if(count==0)
{
    Console.WriteLine("No Staff Found with that name");
}

//Doctors with MBBS specilization

//foreach(Doctor s in doctorLogic.getall())
//{
//    if (s.Specialization == "MBBS")
//    {
//        Console.WriteLine($"{s.StaffName}{s.Email}");
//    }
//}


Console.WriteLine("Entter Name of Employee to Calculate Tax");

nameToSearch = Console.ReadLine();

foreach (Staff s in StaffLogic.staffList)
{
    if(s.StaffName==nameToSearch)
    {
        StaffLogic staff;
        Accounts A = new Accounts();
        switch(s.GetType().Name)
        {
            
            case "Nurse":
                staff = new NurseLogic();
                A.CalculateIncome(staff, s);
                Console.WriteLine("Nurse");
                break;
            case "Doctor":
                staff = new DoctorLogic();
                A.CalculateIncome(staff, s);
                Console.WriteLine("Doctor");
                break;
            case "Technician":
                staff = new TechnicianLogic();
                A.CalculateIncome(staff, s);
                Console.WriteLine("Technician");
                break;
        }
    }
}









