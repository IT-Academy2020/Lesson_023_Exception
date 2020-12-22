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
                try
                {
                    try
                    {
                        throw new Exception("Exception");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Catch 1:" + e.Message);
                        throw;
                    }
                    finally
                    {
                        Console.WriteLine("Finally 1:");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Catch 2:" + e.Message);
                    throw;
                }
                finally
                {
                    Console.WriteLine("Finally 2:");
                    throw new Exception("New Exception");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Catch 3:" + e.Message);
            }
            finally
            {
                Console.WriteLine("Finally 3:");
            }

            // Delay.
            Console.ReadKey();
        }
    }
}