using System;

namespace ISM4300_Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What grade do you expect to get in ISM 4300?");
                int grade = int.Parse(Console.ReadLine());

                if (grade > 90)
                {
                    Console.WriteLine("Your grade will be an A!!!");
                }
                else if (grade > 80 & grade < 89)
                {
                    Console.WriteLine("Your grade will be a B");
                }
                else if (grade > 70 & grade < 79)
                {
                    Console.WriteLine("Your grade will be a C");
                }
                else if (grade > 60 & grade < 69)
                {
                    Console.WriteLine("Your grade will be a D");
                }
                else if (grade < 59)
                {
                    Console.WriteLine("Your grade will be an F");
                }
            }
            catch
            {
                Console.WriteLine("THERE IS AN ERROR!");
            }
        }
    }
}
