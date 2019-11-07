using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_POC_Company
{
    public class Trainee : Employee
    {
        public Trainee(ILogger logger) : base(logger)
        {

        }
        public override double CalculateEmployeeSalary(int hours)
        {
            return hours * 50;
        }
    }
}
