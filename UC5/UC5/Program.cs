using System;

namespace UC5
{
    internal class Program
    {
        
           public const int part_time = 1;
           public const int full_time = 2;
           public const int emp_per_hour_wages = 20;
           public const int Working_days = 20;
        static void Main(string[] args)

        {
            int empHour = 0;
            int empWage = 0;
            int empTotalMonthWage = 0;
            for (int i = 0; i < Working_days; i++)
            {
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
                empWage = empHour * emp_per_hour_wages;
                empTotalMonthWage += empWage;
                //empMonthWage = empWage * Month;
                Console.WriteLine("emp Wage : " + empWage);
            }
            Console.WriteLine("empMonthWage : " + empTotalMonthWage);
        }             
    }
}
