using System;
using System.Threading;

namespace Race
{
    class Road
    {
        private int left = 0;
        private int top = 0;

        private int speed = 0;
        public int Speed
        {
            set
            {
                if (value != 0)
                    speed = 10000 / value;
                else
                    speed = value;
            }
        }

        public Road(int left = 30, int top = 0)
        {
            this.left = left;
            this.top = top;
        }

        public void Movie()
        {
            Thread th = new Thread(DrawStrips);
            th.Start();
            th.IsBackground = true;
        }

        void DrawStrips()
        {
            while (true)
            {
                if (this.speed != 0)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        top = c;

                        // Очищення старої смуги
                        for (int j = 0; j < 45; j++)
                        {
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(left, j); // Ліва смуга
                            Console.Write("");

                            Console.SetCursorPosition(left + 35, j); // Права смуга
                            Console.Write("");
                        }

                        // Малювання нової смуги
                        for (int k = 0; k < 15; k++)
                        {
                            Console.BackgroundColor = ConsoleColor.Gray;

                            Console.SetCursorPosition(left, top); // Ліва смуга
                            Console.Write("");

                            Console.SetCursorPosition(left + 35, top); // Права смуга
                            Console.Write("");

                            top = top + 3;
                            Console.BackgroundColor = ConsoleColor.Black;
                        }

                        Thread.Sleep(this.speed);
                    }
                }
            }
        }
    }
}