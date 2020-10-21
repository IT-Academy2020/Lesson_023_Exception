using System;

namespace Race
{
    class Engine
    {
        bool engineIsDead = false;
        int currentSpeed ​​= 0;
        const int maxSpeed = 200;

        public int Accelerate(int delta = 10)
        {
            // Якщо приріст швидкості менше нуля генеруємо виняток.
            if (delta < 0)
            {
                throw new ArgumentOutOfRangeException("Для розгону, прискорення повинно бути більше нуля.");
            }

            if (engineIsDead)
            {
                return 0;
            }
            else
            {
                currentSpeed += delta;
                // Якщо поточна швидкість перевищує максимально допустиму.
                if (currentSpeed > maxSpeed)
                {
                    engineIsDead = true;
                    currentSpeed = 0;
                    Console.Title = "Поточна Швидкість =" + currentSpeed;

                    EngineIsDeadException ex = new EngineIsDeadException("Двигун перегрівся.");

                    // Встановлюємо гіперпосилання зв'язувану з виключенням.
                    ex.HelpLink = "http://www.CarsRace.com/errorService";

                    // Вставляємо додаткову інформацію про помилку.
                    ex.Data.Add("Час поломки:", string.Format("Двигун вийшов з ладу {0}", DateTime.Now));
                    ex.Data.Add("Причина поломки:", "Ви перевищили допустиму швидкість. Двигун згорів.");

                    throw ex;
                }
                else
                {
                    Console.Title = "Поточна Швидкість =" + currentSpeed;
                    return currentSpeed;
                }
            }
        }
    }
}