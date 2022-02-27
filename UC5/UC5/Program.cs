using System;

namespace UC5
{
    internal class Program
    {
        static void Main(string[] args)

        {
            const int part_time = 1;
            const int full_time = 2;
            const int emp_per_hour_wages = 20;
            const int Month = 20;

            int empHour = 0;
            int empWage = 0;
            int empMonthWage = 0;
            //for (int i = 0; i < 2; i++)
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
                //empMonthWage += empWage;
                empMonthWage = empWage * Month;
                Console.WriteLine("empWage : " + empWage);
            }
            Console.WriteLine("empMonthWage : " + empMonthWage);
        }             
    }
}
