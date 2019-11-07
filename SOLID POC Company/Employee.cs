using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_POC_Company
{
    public class Employee : IDatabase,ISalaryCalculator,IDatabaseV1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        //Inversion
        private readonly ILogger _logger;

        public Employee(ILogger logger)
        {
            //Inversion
            _logger = logger;
        }
        public void Add()
        {
            //Inversion
            // Add to db
            _logger.Log(this.Name + " is added to DB");
        }
        public void Update()
        {
            //Update Employee
        }

        public virtual double CalculateEmployeeSalary(int hours)
        {
            return 500*hours;
        }

        public void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }
}
