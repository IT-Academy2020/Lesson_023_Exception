﻿using System;
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
                throw new Exception("Моє Виняток");
            }
            catch (Exception e)
            {
                Console.WriteLine("Обробка виключення.");
                Console.WriteLine(e.Message);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}