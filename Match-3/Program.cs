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
            window.Closed += (_, e) => window.Close();

            Texture tb = new Texture(path + "Textures\\background.png");
            Sprite background = new Sprite(tb);

            Texture tgem = new Texture(path + "Gems\\green.png");
            Sprite gem = new Sprite(tgem);
            gem.TextureRect = new IntRect(0, 0, 64, 64);

            while (window.IsOpen)
            {
                window.DispatchEvents();
                window.Clear(Color.Black);
                window.Draw(background);
                window.Draw(gem);
                window.Display();
            }
        }
    }
}
