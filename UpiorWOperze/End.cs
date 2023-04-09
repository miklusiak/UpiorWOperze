using System;
using System.Collections.Generic;
using System.Text;

namespace UpiorWOperze
{
    class End
    {        
        public static void GameOver()
        {
            Console.Clear();
            Console.SetCursorPosition((Console.LargestWindowWidth - 20) / 2, (Console.LargestWindowHeight - 10) / 2);
            Console.WriteLine("Przegrałeś!");
            Console.ReadKey();
            Console.Clear();            
            Environment.Exit(0);
        }

        public static void Win()
        {
            Console.Clear();
            Console.SetCursorPosition((Console.LargestWindowWidth - 20) / 2, (Console.LargestWindowHeight - 10) / 2);
            Console.WriteLine("Wygrana!");
            Console.ReadKey();
            Console.Clear();            
            Environment.Exit(0);
        }        
    }
}
