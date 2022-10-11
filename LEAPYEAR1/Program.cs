using System;

namespace leapyear
{
    class program
    {
        public static void Main(string[] args)
        {
            int year = 0;
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a four digit year");

            if (year % 4 == 0)
            {
                Console.WriteLine("yes it is a leap year");

            }
            else
            {
                Console.WriteLine("no it is not leap year");
            }


        }
    }
}
