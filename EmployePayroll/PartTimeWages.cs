using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployePayroll
{
    internal class PartTimeWages
    {
        public static void CalculatePercentage()
        {
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;

            int empHrs = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
               // Console.WriteLine("Emp is present for full time");
            }
            else if(empCheck == IS_PART_TIME)
            {
                empHrs = 4;
                //Console.WriteLine("Emp is present for part time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("Emp absent");
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp daily wage including partime" + empWage);
        }
    }
}
