using System;
        
namespace UC4
{
    internal class Program
    {
        static void Main(string[] args)

        {
            const int part_time = 1;
            const int full_time = 2;
            const int emp_per_hour_wages = 20;

            int empHour = 0;
            int empWage = 0;
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
            Console.WriteLine("empWage : " + empWage);


        }

    }
}

