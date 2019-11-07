using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_POC_Company
{
    public interface ISalaryCalculator
    {
        double CalculateEmployeeSalary(int hours);
    }
}
