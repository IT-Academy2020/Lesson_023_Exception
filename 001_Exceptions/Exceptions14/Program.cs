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