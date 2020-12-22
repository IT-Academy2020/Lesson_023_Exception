using System;
using System.Text;

// Обробка винятків.

// finally - не спрацьовує якщо не завершується робота блоку catch.

namespace Exceptions
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                throw new Exception();

                // або так ...

                while (true)
                    Console.WriteLine("Catch");
            }
            finally
            {
                // finally - не спрацює!
                while (true)
                    Console.WriteLine("Finally");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}