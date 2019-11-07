using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_POC_Company
{
    public class Guest : IDatabase
    {
        public void Add()
        {
            Console.WriteLine("guest Added to db");
        }

        public void Update()
        {
            //Update db
        }
    }
}
