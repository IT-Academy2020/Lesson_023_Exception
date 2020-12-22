using System;
using System.Text;

// Обробка винятків.

// finally - спрацьовує в разі виникнення виключення OutOfMemoryException.

namespace Exceptions
{
    class Program
    {
        public static void Method()
        {
            int[] arr = new int[100000000];
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
                // finally - спрацює.
                Console.WriteLine("Finally");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}