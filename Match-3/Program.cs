using SFML.Graphics;
using SFML.Window;
using System;

namespace Match_3
{
    class Program
    {
        public static string path = "..\\..\\..\\";
        static void Main(string[] args)
        {
            RenderWindow window =
                 new RenderWindow(new VideoMode(740, 480), "Match 3");
            window.SetVerticalSyncEnabled(true);
            window.SetFramerateLimit(60);
            Texture tb = new Texture(path + "Textures\\background.png");
            Sprite background = new Sprite(tb);
            window.Draw(background);
            window.Closed += (_, e) => window.Close();
            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Black);
                window.Display();
            }
        }
    }
}
