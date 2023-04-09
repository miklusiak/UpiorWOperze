using System;
using System.Collections.Generic;
using System.Text;

namespace UpiorWOperze
{
    class Seduction
    {
        
        public static void StartSeduction()
        {
            Console.Title = "Wybierz, jak SKUTECZNIE uwiódłbyś Christine?";
            int stop = 0;

            while(stop < 1)
            {
                SeductionText.FirstSeduction();

                ConsoleKeyInfo decision = Console.ReadKey();
                switch(decision.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        Console.Clear();
                        RightSeduction1();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        Console.Clear();
                        WrongSeduction();
                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.Clear();
                        WrongSeduction();
                        break;

                    case ConsoleKey.Escape:
                        Console.WriteLine("Zrezygnowano z dalszej gry...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        End.GameOver();
                        break;
                }

                static void RightSeduction1()
                {
                    SeductionText.SecondSeduction();

                    ConsoleKeyInfo decision = Console.ReadKey();
                    switch (decision.Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            Console.Clear();
                            WrongSeduction();
                            break;

                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            Console.Clear();
                            WrongSeduction();
                            break;

                        case ConsoleKey.D3:
                        case ConsoleKey.NumPad3:
                            Console.Clear();
                            RightSeducion2();
                            break;

                        case ConsoleKey.Escape:
                            Console.WriteLine("Zrezygnowano z dalszej gry...");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;

                        default:
                            break;
                    }

                    static void RightSeducion2()
                    {
                        SeductionText.ThirdSeduction();

                        ConsoleKeyInfo decision = Console.ReadKey();
                        switch (decision.Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                Console.Clear();
                                WrongSeduction();
                                break;

                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                                Console.Clear();
                                RightSedution3();
                                break;

                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Clear();
                                WrongSeduction();
                                break;

                            case ConsoleKey.Escape:
                                Console.WriteLine("Zrezygnowano z dalszej gry...");
                                Console.ReadKey();
                                Environment.Exit(0);
                                break;

                            default:
                                break;

                        }
                        static void RightSedution3()
                        {
                            SeductionText.FourthSeduction();

                            ConsoleKeyInfo decision = Console.ReadKey();
                            switch (decision.Key)
                            {
                                case ConsoleKey.D1:
                                case ConsoleKey.NumPad1:
                                    Console.Clear();
                                    RightSedution4();
                                    break;

                                case ConsoleKey.D2:
                                case ConsoleKey.NumPad2:
                                    Console.Clear();
                                    WrongSeduction();
                                    break;

                                case ConsoleKey.D3:
                                case ConsoleKey.NumPad3:
                                    Console.Clear();
                                    WrongSeduction();
                                    break;

                                case ConsoleKey.Escape:
                                    Console.WriteLine("Zrezygnowano z dalszej gry...");
                                    Console.ReadKey();
                                    Environment.Exit(0);
                                    break;

                                default:
                                    break;

                            }
                            static void RightSedution4()
                            {
                                SeductionText.FifthSeduction();

                                ConsoleKeyInfo decision = Console.ReadKey();
                                switch (decision.Key)
                                {
                                    case ConsoleKey.D1:
                                    case ConsoleKey.NumPad1:
                                        Console.Clear();
                                        WrongSeduction();
                                        break;

                                    case ConsoleKey.D2:
                                    case ConsoleKey.NumPad2:
                                        Console.Clear();
                                        PerfectGame();
                                        //exit = true;
                                        break;

                                    case ConsoleKey.D3:
                                    case ConsoleKey.NumPad3:
                                        Console.Clear();
                                        WrongSeduction();
                                        break;

                                    case ConsoleKey.Escape:
                                        Console.WriteLine("Zrezygnowano z dalszej gry...");
                                        Console.ReadKey();
                                        Environment.Exit(0);
                                        break;

                                    default:
                                        break;

                                }

                                static void PerfectGame()
                                {
                                    Console.SetCursorPosition((Console.LargestWindowWidth - 40) / 2, (Console.LargestWindowHeight - 10) / 2);
                                    Console.WriteLine(" Fantastycznie Ci poszło! ");
                                    Console.SetCursorPosition((Console.LargestWindowWidth - 60)/ 2, (Console.LargestWindowHeight - 8) / 2);
                                    Console.WriteLine(" Christine nie mogła sie oprzec Twojemu głosowi... ");
                                    Console.SetCursorPosition((Console.LargestWindowWidth - 40) / 2, (Console.LargestWindowHeight - 6) / 2);
                                    Console.WriteLine(" Ukończyłeś 1. zadanie! ");
                                    Console.ReadKey();
                                }
                            }
                        }
                    }
                }
                static void WrongSeduction()
                {
                    Console.SetCursorPosition((Console.LargestWindowWidth - 50) / 2, (Console.LargestWindowHeight - 10) / 2);
                    Console.WriteLine("Pomyliłeś się ... Twoja pewność siebie Cię zwiodła...");
                    Console.ReadKey();
                    End.GameOver();
                    Console.ReadKey();
                }
                stop++;
            }            
        }
    }
}
