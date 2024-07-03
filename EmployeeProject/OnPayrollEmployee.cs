using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProject
{
    internal class OnPayrollEmployee : Employee
    {
        
        public DateTime JoiningDate { get; set; }
        public int Exp { get; set; }
        public double BasicSalary { get; set; }
        public double DA { get; set; }
        public double HRA { get; set; }
        public double PF { get; set; }
        public double NetSalary {  get; set; }
        public OnPayrollEmployee() : base() { }
        public OnPayrollEmployee(int id, string name, string reportingManager,
           DateTime joiningDate, 
          int exp,
         double basicSalary) : base(id, name, reportingManager)
        {
            JoiningDate = JoiningDate;
            Exp = exp;
            basicSalary = basicSalary;
        }
        public void GetDetails()
        {

        }
        public override void DisplayDetails()
        {
            Console.WriteLine("OnPayroll Employee");
            Console.WriteLine("*******************");
            CalculateNetSalary();
            base.DisplayDetails();
            Console.WriteLine("JoiningDate is " + JoiningDate);
            Console.WriteLine("Exp is " + Exp);
            Console.WriteLine("BasicSalary is " + BasicSalary);
            Console.WriteLine("DA is " + DA);
            Console.WriteLine("HRA is " + HRA);
            Console.WriteLine("PF is " + PF); 
            Console.WriteLine("NetSalary is " + NetSalary);

        }
        public void CalculateNetSalary()
        {
            //            if exp > 10 years , DA = 10% of basic, HRA = 8.5 % of basic , PF = 6200
            //if exp > 7 years and less than 10 years , DA = 7% of basic, HRA = 6.5 % of basic , PF = 4100
            //if exp > 5 years and less than 7 years, DA = 4.1% of basic, HRA = 3.8 % of basic , PF = 1800
            //if exp < 5 years , DA = 1.9% of basic, HRA = 2.0 % of basic , PF = 1200
            if (Exp >= 10)
            {
                DA = .01 * BasicSalary;
                HRA = .85 * BasicSalary;
                PF = 6200;
            }
            else if (Exp>= 7 && Exp <10) 
                {

                    DA = .07 * BasicSalary;
                    HRA = .65 * BasicSalary;
                    PF = 4100;
                }

                else if (Exp > 5 && Exp <7)
                
                    {

                        DA = .41 * BasicSalary;
                        HRA = .38 * BasicSalary;
                        PF = 1800;
                    }
                else if(Exp <5)
                {
                DA = .19 * BasicSalary;
                HRA = .2 * BasicSalary;
                PF = 1200;

            }
            NetSalary = (BasicSalary + DA + HRA) - PF;

        }
    }

    }

