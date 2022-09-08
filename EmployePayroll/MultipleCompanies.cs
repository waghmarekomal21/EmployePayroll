﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployePayroll
{
    internal class MultipleCompanies
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        public static void calculate(string company, int empRatePerHour, int numOfWorkinDay, int MaxHourPerMonth)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkinDays = 0;

            while (totalEmpHrs <= MaxHourPerMonth && totalWorkinDays < numOfWorkinDay)
            {
                totalWorkinDays++;

                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case 1:
                        empHrs = 4;
                        break;
                    case 2:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;

                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#: " + totalWorkinDays + " Employee hours : " + empHrs + " Total employee hours : " + totalEmpHrs);
            }
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total employee wage for company : " + company + " is : " + totalEmpWage);
        }
    }
}
