using System;

namespace UC6
{
    internal class Program
    {
        public const int part_time = 1;
        public const int full_time = 2;
        public const int emp_per_hour_wages = 20;
        public const int Month = 20;
        public const int MaxHoursInMonth = 100;
        //public const int NoofworkingDays = 2;
        static void Main(string[] args)

        {
            //variables
            int empHour = 0;
            int empTotalHour = 0;
            int empTotalWorkingDays = 0;
            //for (int i = 0; i < 2; i++)
            while (empTotalHour <= MaxHoursInMonth && empTotalWorkingDays < Month)
            { 
                empTotalWorkingDays++;
                Random random = new Random();
                int check = random.Next(0, 3);
                switch (check)
                {
                    case part_time:
                        empHour = 4;
                        break;
                    case full_time:
                        empHour = 8;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                empTotalHour += empHour;
                Console.WriteLine("Days : " + empTotalWorkingDays + " Emp Hours : " + empHour);
            }
            int TotalEmpWages = empTotalHour * emp_per_hour_wages;
            Console.WriteLine("Total Emp Wages : " + TotalEmpWages);
            
        }
    }
}

