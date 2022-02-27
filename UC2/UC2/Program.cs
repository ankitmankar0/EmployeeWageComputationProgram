using System;

namespace UC2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int full_time = 1;
            int emp_per_hour_wages = 20;

            int empHour = 0;
            int empWage = 0;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == full_time)
            {
                empHour = 8;

            }
            else
            {
                empHour = 8;
            }
            empWage = empHour * emp_per_hour_wages;
            Console.WriteLine("empWage : " + empWage);
        }
    }
}

