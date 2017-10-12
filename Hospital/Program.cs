using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Surgeon Jenny = new Surgeon("Jenny", 234, "Operating", false);
            Surgeon Meredith = new Surgeon("Meredith", 645, "Operating", true);
            Nurse Sonny = new Nurse("Sonny", 789, "Patient_Care", 6);
            Nurse Anthony = new Nurse("Anthony", 123, "Patient_Care", 4);
            Receptionist Tom = new Receptionist("Tom", 951, "Patient_Care", true);

            Console.WriteLine(Jenny.EmployeeName + " " + Jenny.EmployeeNumber + " " + Jenny.SpecialtyArea + " " + Jenny.CurrentlyOperating);
            Console.WriteLine(Meredith.EmployeeName + " " + Meredith.EmployeeNumber + " " + Meredith.SpecialtyArea + " " + Meredith.CurrentlyOperating);
            Console.WriteLine(Sonny.EmployeeName + " " + Sonny.EmployeeNumber + " " + Sonny.Department + " " + Sonny.NumberOfPatients);
            Console.WriteLine(Anthony.EmployeeName + " " + Anthony.EmployeeNumber + " " + Anthony.Department + " " + Anthony.NumberOfPatients);
            Console.WriteLine(Tom.EmployeeName + " " + Tom.EmployeeNumber + " " + Tom.Department + " " + Tom.IsOnPhone);
        }
    }
}
