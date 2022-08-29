using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployePayroll
{
    internal class PartTimeWagesSwitchcase
    {
        public static void CalculateWage()
        {
            const int EMP_RATE_PER_HOUR = 20;
            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case 1:
                    empHrs = 8;
                    Console.WriteLine("Employee is present for full time");
                    break;
                case 2:
                    empHrs = 4;
                    Console.WriteLine("Employee is present for part time");
                    break;
                default:
                    empHrs = 0;
                    Console.WriteLine("Employee is absent");
                    break;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee daily wage including the part time is" + empWage);

        }
    }
}

