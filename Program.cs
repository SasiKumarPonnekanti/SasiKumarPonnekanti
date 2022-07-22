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





