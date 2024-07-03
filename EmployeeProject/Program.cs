namespace EmployeeProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() ;
            Employee employee;
            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("ENter what type of Employee you are");
                int ch = byte.Parse(Console.ReadLine());
                if (ch == 1)
                {
                    employee = new OnContractEmployee(10, "Ajay", "Deepak", Convert.ToDateTime("12/12/2022"), 10, 12000f);
                    //emploee.DisplayDetails();
                    employees.Add(employee);

                }
                else
                    if (ch == 2)
                {
                    employee = new OnPayrollEmployee(11, "Deepak", "gagan", Convert.ToDateTime(DateTime.Now), 10, 25000f);
                    //emploee.DisplayDetails();
                    //employee.CalculateNetSalary();
                    employees.Add(employee);

                }
                Console.WriteLine("Want to add more record");
                choice = Console.ReadLine();
            }
            Employee temp= new Employee();
            foreach(Employee emp in employees)
            {
                if (emp.GetType() == typeof(OnContractEmployee))
                {
                   temp= (OnContractEmployee)emp;
                }
                else if(emp.GetType() == typeof(OnPayrollEmployee))
                {
                    temp = (OnPayrollEmployee)emp;
                }
                temp.DisplayDetails();
            }
            Console.WriteLine("TOTAL NO OF EMPLOYEES " + employees.Count);
        }
    }
}
