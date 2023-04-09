using System;
using System.Media;

namespace UpiorWOperze
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxHeight = Console.LargestWindowHeight;
            int maxWidth = Console.LargestWindowWidth;
            Labirynth board = new Labirynth();

            /*SoundPlayer soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "path";
            soundPlayer.PlayLooping();*/

            Dialogue game = new Dialogue();

            FullScreen.Screen(maxWidth, maxHeight);
            game.Wellcome(maxWidth, maxHeight);
            game.GetIn();
            game.Task1();
            FullScreen.Screen(maxWidth, maxHeight);
            game.Task2();
            board.Draw();

        }
    }
}
