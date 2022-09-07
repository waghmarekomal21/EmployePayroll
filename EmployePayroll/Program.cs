namespace EmployePayroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Wage!");
            Console.WriteLine("Choose option\n 1.Check absent or present\n2.Check daily employee wage\n3.Part time wage\n4.Part time wage using switch case\n5.Monthly Wages\n6.Total Working Hours Of Employe");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    EmployeePresentAbsent.Random();
                    break;
                case 2:
                    Dailywages.CalculateDailyWage();
                    break;
                case 3:
                    PartTimeWages.CalculatePercentage();
                    break;
                case 4:
                    PartTimeWagesSwitchcase.CalculateWage();
                    break;
                case 5:
                    MonthlyWage.CalculateMonthlyWage();
                    break;
                case 6:
                    TotalWorkingHours.WorkingHours();
                    break;
                case 7:
                    Refactor.CalculateEmpWage();
                    break;
                case 8:
                    MultipleCompanies.calculate("D-Mart", 20, 30, 100);
                    MultipleCompanies.calculate("Reliance", 20, 30, 100);
                        break;
                default:
                    Console.WriteLine("Entered wrong choice");
                    break;
            }
            
        }
    }
}
              
