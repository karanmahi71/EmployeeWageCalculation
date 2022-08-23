using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employee
    {
        const int isfulltime = 1;
        const int isparttime = 2;
        Random random = new Random();
        int emphrs = 0, Wageperhts = 20;
        public void Attendance()
        {
            int result = ramdom.Next(0, 3);
            if (result == 1)
            {
                Console.WriteLine("employee is present");
                emphrs += 8;
            }
            else if (result == 2)
            {
                Console.Writeline("employee is absent");
            }
            public int DailyWage()
            {
                return emphrs * Wageperhts
            }
        }
    }
