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
                Console.WriteLine("Обробка виключення.");
                userException.Method();

                try
                {
                    FileStream fs = File.Open(@"C: \ NonExistentFile.log", FileMode.Open);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            // Delay.
            Console.ReadKey();
        }
    }
}