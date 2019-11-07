using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_POC_Company
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<ISalaryCalculator> emps = new List<ISalaryCalculator>{
            //    new Manager(),
            //    new Tester(),
            //    new Trainee()
            //};

            //foreach (var emp in emps)
            //{
            //    Console.WriteLine(emp.CalculateEmployeeSalary(5));
            //}

            //List<Employee> emps2 = new List<Employee>{
            //    new Manager(),
            //    new Tester()
            //}; 
            //foreach (Employee emp in emps2)
            //{
            //    emp.Add(emp);
            //    emp.CalculateEmployeeSalary(10);
            //}
            ////Manager manager = new Manager();
            ////Console.WriteLine(manager.CalculateSalary(5));
            ////Tester tester = new Tester();
            ////Console.WriteLine(tester.CalculateSalary(5));
            //Console.ReadLine();


            /////////////////Liskov
            ///

            int numberOfHours = 5;
            ILogger consoleLogger = new ConsoleLogger();
            ILogger fileLogger = new FileLoggger();



            List<Employee> emps = new List<Employee>()
            {
                new Manager(fileLogger){ Name= "hamada"},
                new Tester(fileLogger){ Name="lamees"},
                new Trainee(fileLogger){Name="sondos"}
            };

            foreach (var emp in emps)
            {
                emp.Add();
                Console.WriteLine("salary per "+ numberOfHours + " hours: "+ emp.CalculateEmployeeSalary(numberOfHours));
            }
            Console.ReadLine();
        }
    }
}
