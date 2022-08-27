using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployePayroll
{
    internal class EmployeePresentAbsent
    {
        public static void Random()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 2);

            switch (empcheck = 0)
            {
                case 0:
                    Console.WriteLine("is present");
                    break;
                case 1:
                    Console.WriteLine("is abscent");
                    break;
                default:
                    break;
            }
        }
    }
}
