using System;

// Обробка винятків.

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            int a = 1, n = 2;

            try
            {
                // Спроба ділення на нуль.
                a = a / (2 - n);

                Console.WriteLine("a = {0}", a);
            }
            catch (Exception e)
            {
                Console.WriteLine("Обробка виключення.");
                Console.WriteLine(e.Message);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}