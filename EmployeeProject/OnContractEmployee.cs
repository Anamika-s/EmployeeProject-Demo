using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class OnContractEmployee : Employee
    {
        public DateTime ContractDate { get; set; }
        public int Duration { get; set; }
        public double Charges { get; set; }

        public OnContractEmployee() { }
        public OnContractEmployee(int id, string name, string reportingManager,
           DateTime contractDate,
          int duration,
         float charges) : base(id, name, reportingManager)
        {
            this.ContractDate = contractDate;
            this.Duration = duration;
            Charges = charges;
        }

        public override void DisplayDetails()
        {

            Console.WriteLine("OnContract Employee");
            Console.WriteLine("*******************");
            base.DisplayDetails();
            Console.WriteLine("ContractDate is " + ContractDate);
            Console.WriteLine("Duration is " + Duration);
            Console.WriteLine("Charges are " + Charges);

        }
    }
}