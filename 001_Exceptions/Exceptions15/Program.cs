using System;
using System.Text;

// Обробка винятків. (Порядок обробки виключень)

namespace Exceptions
{
    class MyExceptionA : Exception
    {
        public MyExceptionA(string message) : base(message)
        {
        }
    }

    class MyExceptionB : MyExceptionA
    {
        public MyExceptionB(string message) : base(message)
        {
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            try
            {
                // throw new Exception ( "Exception");
                throw new MyExceptionA("MyExceptionA");
                // throw new MyExceptionB ( "MyExceptionB");
            }
            catch (MyExceptionB e)
            {
                Console.WriteLine(e.Message);
            }
            catch (MyExceptionA e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}