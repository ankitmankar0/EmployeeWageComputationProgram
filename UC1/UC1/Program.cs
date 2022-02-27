using System;

namespace UC1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int full_time = 1;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == full_time)
            {
                Console.WriteLine("emp is present");

            }
            else
            {
                Console.WriteLine("emp is absent");
            }
            
        }
    }
}
