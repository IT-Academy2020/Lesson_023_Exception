using System;
using System.Text;

// Обробка винятків.

// finally - не спрацьовує в разі виникнення виключення StackOverflowException.

namespace Exceptions
{
    class Program
    {
        public static void Method()
        {
            int[] arr = new int[10];
            Console.WriteLine(arr);
            Method();
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                Method();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // finally - не спрацює.
                while (true)
                    Console.WriteLine("Finally");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}