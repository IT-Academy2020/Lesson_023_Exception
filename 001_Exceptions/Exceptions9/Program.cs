using System;
using System.Text;

// Обробка внутрішніх винятків.

namespace Exceptions
{
    public class ClassWithException
    {
        public void ThrowInner()
        {
            throw new Exception("Це внутрішнє виняток!");
        }

        public void CatchInner()
        {
            try
            {
                this.ThrowInner();
            }
            catch (Exception e)
            {
                throw new Exception("Це зовнішнє виняток!", e);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            ClassWithException instance = new ClassWithException();
            //instance.CatchInner (); // Спробувати викликати.
            try
            {
                instance.CatchInner();
            }
            catch (Exception exception)
            {
                Console.WriteLine("Exception caught: {0}", exception.Message);
                Console.WriteLine("Inner Exception: {0}", exception.InnerException.Message);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}