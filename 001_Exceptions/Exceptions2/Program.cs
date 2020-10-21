using System;

// Обробка винятків.

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            Exception ex = new Exception("Моє Виняток");

            try
            {
                throw ex;
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