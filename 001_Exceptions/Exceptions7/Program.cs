using System;
using System.Text;

// Обробка винятків.

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            int a = 1, n = 2;

            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Спроба ділення на нуль.");
                //Console.WriteLine("a / (2 - n) = {0}", a / (2 - n));
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Обробка виключення.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine("Press any key ...");

            // Delay.
            Console.ReadKey();
        }
    }
}