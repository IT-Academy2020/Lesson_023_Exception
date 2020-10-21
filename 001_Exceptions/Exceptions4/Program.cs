using System;
using System.Collections;

// Обробка винятків.

namespace Exceptions
{
    class MyClass
    {
        public void MyMethod()
        {
            Exception exception = new Exception("Моє виключення");

            exception.HelpLink = "http://MyCompany.com/ErrorService";
            exception.Data.Add("Причина виключення:", "Тестове виключення");
            exception.Data.Add("Час виникнення виключення:", DateTime.Now);

            throw exception;
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                MyClass instance = new MyClass();
                instance.MyMethod();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ім'я члена: {0}", e.TargetSite);
                Console.WriteLine("Клас визначає член: {0}", e.TargetSite.DeclaringType);
                Console.WriteLine("Тип члена: {0}", e.TargetSite.MemberType);
                Console.WriteLine("Message: {0}", e.Message);
                Console.WriteLine("Source: {0}", e.Source);
                Console.WriteLine("Help Link: {0}", e.HelpLink);
                Console.WriteLine("Stack: {0}", e.StackTrace);

                foreach (DictionaryEntry de in e.Data)
                    Console.WriteLine("{0}: {1}", de.Key, de.Value);
            }

            // Delay.
            Console.ReadKey();
        }
    }
}