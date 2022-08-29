using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployePayroll
{
    internal class TotalWorkingHours
    {   
        const int NUM_WORKING_DAYS = 20;
        const int EMP_RATE_PER_HOUR = 20;
        public static void WorkingHours()
        {
            int empHour = 0; int empWage = 0; int totalEmpHr = 0; int totalWorkingDays = 0; int totalEmpWage = 0;

            while (totalEmpHr <= 100 && totalWorkingDays <= NUM_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 2);
                switch (empcheck)
                {
                    case 0: 
                        empHour = 8; 
                        break;
                    case 1: 
                        empHour = 4; 
                        break;
                    default: 
                        empHour = 0; 
                        break;
                }
                empWage = empHour * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Employe daily wage is " + empWage);
                totalEmpHr += empHour;
                Console.WriteLine("Total emp Hour :" + totalEmpHr);

            }
            Console.WriteLine("total emp wage is :" + totalEmpWage);
        }
    }
}