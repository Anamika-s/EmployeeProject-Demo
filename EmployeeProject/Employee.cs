using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ReportingManager { get; set; }
        public Employee()
        {
            
        }

        public Employee(int id, string name, string reportingManager)
        {
            Id = id;
            Name = name;
            ReportingManager = reportingManager;
        }
        public void GetDetails()
        {
            Console.WriteLine("enter id");
        }
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"id is {Id}");
            Console.WriteLine($"name is {Name }");
            Console.WriteLine($"reportingManager is {ReportingManager}");
        }
    }
}
