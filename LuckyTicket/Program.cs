using System;

namespace LuckyTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while (true)
            {
                Console.WriteLine("\r\nEnter your ticket number. The number should be 4 to 8 digits long.");
                input = Console.ReadLine();
                try
                {
                    var number = Convert.ToInt32(input);
                    if (input.Length < 3 || input.Length > 8)
                    {
                        Console.WriteLine("The number should be 4 to 8 digits long. Please try again.");
                        continue;
                    }
                    if (input.Length % 2 != 0)
                    {
                        input = $"0{input}";
                        number = Convert.ToInt32(input);
                    }
                    var number1 = Convert.ToInt32(input.Substring(0, input.Length / 2));
                    var number2 = Convert.ToInt32(input.Substring(input.Length / 2, input.Length / 2));
                    int number1sum = 0;
                    int number2sum = 0;
                    while (!(number2 <= 0 && number1 <= 0))
                    {
                        number1sum += number1 % 10;
                        number1 /= 10;
                        number2sum += number2 % 10;
                        number2 /= 10;
                    }
                    Console.WriteLine(number1sum);
                    Console.WriteLine(number2sum);
                    if (number1sum == number2sum)
                    {
                        Console.WriteLine("Congratulations, your ticket is lucky!");
                    }
                    else
                    {
                        Console.WriteLine("Unfortunately, your ticket isn't lucky.");
                    }
                }
                catch
                {
                    Console.WriteLine("\r\nThe entered data is incorrect! Please try again.");
                }
            }
        }
    }
}
