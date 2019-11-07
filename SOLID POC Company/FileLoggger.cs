using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_POC_Company
{
    public class FileLoggger : ILogger
    {
        public void Log(string info)
        {
            Console.WriteLine("file: " + info);
        }
    }
}
