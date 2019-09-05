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
                    Console.WriteLine("You've got a bright future ahead of you!!! :D ");
                }
                else if (grade > 80 & grade < 89)
                {
                    Console.WriteLine("Your grade will be a B");
                }
                else if (grade > 70 & grade < 79)
                {
                    Console.WriteLine("Your grade will be a C");
                    Console.WriteLine("There's room for improvement");
                }
                else if (grade > 60 & grade < 69)
                {
                    Console.WriteLine("Your grade will be a D");
                    Console.WriteLine("Is there something going on?");
                }
                else if (grade < 59)
                {
                    Console.WriteLine("Your grade will be an F");
                    Console.WriteLine("You might wanna consider another career :( ");
                }
            }
            catch
            {
                Console.WriteLine("THERE IS AN ERROR!");
            }
        }
    }
}
