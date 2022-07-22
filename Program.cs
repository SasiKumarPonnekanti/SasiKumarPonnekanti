using ConsoleApp2.Models;
using ConsoleApp2.Logic;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Staff doctor = new Doctor() { StaffName="SasiDoctor"};
Staff technician = new Technician() { StaffName="SasiTech"};
Staff nurse = new Nurse() { StaffName="SasiNurse"};



StaffLogic doctorLogic = new DoctorLogic();
StaffLogic nurseLogic = new NurseLogic();
StaffLogic technicianLogic = new TechnicianLogic();

doctorLogic.staff.Add(doctor);
nurseLogic.staff.Add(nurse);
technicianLogic.staff.Add(technician);

foreach(Staff staff in doctorLogic.staff)
{
    Console.WriteLine(staff.StaffName);
}



Accounts ac = new Accounts();
Console.WriteLine($"{ac.CalculateIncome(doctorLogic)}");
Console.WriteLine($"{ac.CalculateIncome(nurseLogic)}");
Console.WriteLine($"{ac.CalculateIncome(technicianLogic)}");