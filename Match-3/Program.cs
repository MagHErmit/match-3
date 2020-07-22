using SFML.Graphics;
using SFML.Window;
using System;

namespace Match_3
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow window =
                 new RenderWindow(new VideoMode(800, 600), "Hello SFML!");

            while (window.IsOpen == true)
            {
                window.DispatchEvents();

                window.Display();
            }
        }
    }
}
