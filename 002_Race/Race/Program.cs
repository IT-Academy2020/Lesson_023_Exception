using System;

namespace Race
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Car";

            // Здається розмір вікна.
            Console.SetWindowSize(100, 50);

            // Здається видимість курсора.
            Console.CursorVisible = true;

            Game game = new Game();
            game.Run();

            // Delay.
            Console.ReadKey();
        }
    }
}