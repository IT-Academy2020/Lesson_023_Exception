using System;
using System.IO;
using System.Text;

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
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                throw new UserException();
            }
            catch (UserException userException)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Обробка виключення 1:");
                userException.Method();

                try
                {
                    throw userException;
                }
                catch (UserException exception)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Обробка виключення 2:");
                    exception.Method();
                }
            }
            finally
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.WriteLine("Press any key ...");

            // Delay.
            Console.ReadKey();
        }
    }
}