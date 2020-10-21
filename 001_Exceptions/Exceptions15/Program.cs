using System;

// Обробка винятків. (Порядок обробки виключень)

namespace Exceptions
{
    class MyExceptionA : Exception
    {
        public MyExceptionA(string message)
            : Base(message)
        {
        }
    }

    class MyExceptionB : MyExceptionA
    {
        public MyExceptionB(string message)
            : Base(message)
        {
        }
    }

    class Program
    {
        static void Main()
        {
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