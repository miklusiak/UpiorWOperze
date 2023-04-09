using System;
using System.Collections.Generic;
using System.Text;

namespace UpiorWOperze
{
    class Labirynth
    {
        Phantom character = new Phantom();
        bool exit = false;
        double moveTime = 1000 / 4.0;
        DateTime lastDate = DateTime.Now;
        List<Move> wall = new List<Move>();
        Move search = new Move();


        public void Draw()
        {
            Console.Clear();

            int w = 120;
            int h = 30;
            
            for (int i = 0; i < h; i++)
            { 
                for(int j = 0; j < w; j++)
                {
                    if (i == 0 || i == h - 1 || ((i > 0 && i < h - 1) && (j < 1 || j > w - 2)) || (i == 3 && ((j > 0 && j < 7) || (j > 68 && j < 115))) || (i > 0 && i < 15 && j == 68) || (i == 25 && ((j < w - 1 && j > 74) || (j > 0 && j < 24)) ||
                        (i < h - 1 && i > 20 && j == 25) || (i == 14 && j > 35 && j < 68) || (i == 27 && j < 117 && j > 57) || (i == 7 && ((j < 5 && j > 58) || (j < 11 && j > 0)) ||
                        (i > 14 && i < 18 && j > 100 && j < 106) || (i < 9 && i > 0 && j == 45))) || (i == 9 && j > 34 && j < 50) || (i == 17 && j > 82 && j < 101))
                    {
                        Console.Write("#", Console.ForegroundColor = ConsoleColor.Gray);
                    }
                    else if ((i > 1 && i < 10 && j > 12 && j < 35) || (i > 3 && i < 10 && j > 86 && j < 99) || (i > 15 && i < 20 && j > 15 && j < 41) || (i > 12 && i < 15 && j > 68 && j < 83))
                    {
                        Console.Write("@", Console.ForegroundColor = ConsoleColor.Red);
                    }
                    else if ((i == 27 && j > 3 && j < 18) || (i > 14 && i < 28 && j > 49 && j < 56) || (i == 12 && j < 30))
                    {
                        Console.Write("W", Console.ForegroundColor = ConsoleColor.Cyan);
                    }
                    else if (i == 1 && j == 70)
                    {
                        Console.Write("X", Console.ForegroundColor = ConsoleColor.DarkRed);
                    }

                    else { Console.Write(" "); }
                }
                Console.WriteLine("");
            }            
            Console.ReadKey();

            while (!exit)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo input = Console.ReadKey();

                    switch(input.Key)
                    {
                        case ConsoleKey.Escape:
                            exit = true;
                            break;

                        case ConsoleKey.LeftArrow:
                            if (character.AbleToMove() == true && character.FinishLabirynth()==false)
                                character.Direction = Direction.Left;
                            else if (character.AbleToMove() == true && character.FinishLabirynth() == true)
                            {
                                character.Direction = Direction.None;
                                character.CorrectLabirynth();
                            }
                            else
                            {
                                character.Direction = Direction.None;
                                End.GameOver();
                            }
                            break;

                        case ConsoleKey.RightArrow:
                            if (character.AbleToMove() == true && character.FinishLabirynth() == false)
                                character.Direction = Direction.Right;
                            else if (character.AbleToMove() == true && character.FinishLabirynth() == true)
                            {
                                character.Direction = Direction.None;
                                character.CorrectLabirynth();
                            }
                            else
                            {
                                character.Direction = Direction.None;
                                End.GameOver();
                            }
                            break;

                        case ConsoleKey.UpArrow:
                            if (character.AbleToMove() == true && character.FinishLabirynth() == false)
                                character.Direction = Direction.Up;
                            else if (character.AbleToMove() == true && character.FinishLabirynth() == true)
                            {
                                character.Direction = Direction.None;
                                character.CorrectLabirynth();
                            }
                            else
                            {
                                character.Direction = Direction.None;
                                End.GameOver();
                            }
                            break;

                        case ConsoleKey.DownArrow:
                            if (character.AbleToMove() == true && character.FinishLabirynth() == false)
                                character.Direction = Direction.Down;
                            else if (character.AbleToMove() == true && character.FinishLabirynth() == true)
                            {
                                character.Direction = Direction.None;
                                character.CorrectLabirynth();
                            }
                            else
                            {
                                character.Direction = Direction.None;
                                End.GameOver();
                            }
                            break;

                        case ConsoleKey.Spacebar:
                            character.Direction = Direction.None;
                            break;
                        
                    }
                }
                if ((DateTime.Now - lastDate).TotalMilliseconds >= moveTime && character.AbleToMove() == true && character.FinishLabirynth() == false)
                {
                    character.Run();
                    lastDate = DateTime.Now;
                }
            }            
        }
    }
}
