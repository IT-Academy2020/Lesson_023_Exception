using System;

// Обробка винятків.

namespace Exceptions
{
    // Для створення призначеного для користувача винятку, потрібно успадкування від System.Exception.
    class UserException : Exception
    {
        public void Method()
        {
            Console.WriteLine("Моє Виняток!");
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                throw new UserException();
            }
            catch (UserException e)
            {
                Console.WriteLine("Обробка виключення.");
                e.Method();
            }

            // Delay.
            Console.ReadKey();
        }
    }
}