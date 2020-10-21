using System;

// Обробка винятків.

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            try
            {
                throw new Exception("Моє Виняток");
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