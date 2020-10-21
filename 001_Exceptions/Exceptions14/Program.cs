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
                throw null;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}