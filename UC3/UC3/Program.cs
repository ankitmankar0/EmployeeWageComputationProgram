using System;

namespace UC3
{
    internal class Program
    {
        static void Main(string[] args)

        { 
            int part_time = 1;
            int full_time = 2;
            int emp_per_hour_wages = 20;

            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == part_time)
            {
                empHour = 4;
            }
            else if (check == full_time)
            {
                empHour = 8;
            }
            else
            {
                empHour = 0; 
            }
            empWage = empHour * emp_per_hour_wages;
            Console.WriteLine("empWage : " + empWage);
        }
    }
}
