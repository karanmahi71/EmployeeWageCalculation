using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        int isPresent = 1;
        Random random = new Random();
        public void Attendance()
        {
            int result = random.Next(0, 2);
            if (result == isPresent)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }

        }
    }
}
