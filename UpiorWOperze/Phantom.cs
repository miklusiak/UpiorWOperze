using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UpiorWOperze
{
    class Phantom : IPhantom
    {
        Dialogue game = new Dialogue();

        public Direction Direction { get; set; } = Direction.Right;
        public Move Position { get; set; } = new Move();
        public List<Move> Point { get; set; } = new List<Move>();
        public int Length { get; } = 1; 
        private bool outOfRange = false;

        public void Run()
        {
            switch(Direction)
            {
                case Direction.Left:
                    Position.X--;
                    break;
                case Direction.Right:
                    Position.X++;
                    break;
                case Direction.Up:
                    Position.Y--;
                    break;
                case Direction.Down:
                    Position.Y++;
                    break;
                case Direction.None:
                    Position.X = Position.X;
                    Position.Y = Position.Y;
                    break;
            }
            try
            {
                Console.SetCursorPosition(Position.X, Position.Y);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("$");
                Point.Add(new Move(Position.X, Position.Y));                

                if (Point.Count > this.Length)
                {
                    var endpoint = Point.First();
                    Console.SetCursorPosition(endpoint.X, endpoint.Y);
                    Console.Write(" ");
                    Point.Remove(endpoint);
                }
                 
            }
            catch(ArgumentOutOfRangeException)
            {       
                if (Position.X == 1 && Position.Y == 70)
                {
                    FinishLabirynth();
                }
                outOfRange = true;
            }
        }
        public bool AbleToMove()
        {
            int j = Position.X;
            int i = Position.Y;

            if (i == 29 || j == 119 || j == 0 || i == 0 || (i == 3 && ((j > 0 && j < 7) || (j > 68 && j < 115))) || (i > 0 && i < 15 && j == 68) || (i == 25 && ((j < 119 && j > 74) || (j > 0 && j < 24)) ||
                        (i < 29 && i > 20 && j == 25) || (i == 14 && j > 35 && j < 68) || (i == 27 && j < 117 && j > 57) || (i == 7 && ((j < 5 && j > 58) || (j < 11 && j > 0)) ||
                        (i > 14 && i < 18 && j > 100 && j < 106) || (i < 9 && i > 0 && j == 45))) || (i == 9 && j > 34 && j < 50) || (i == 17 && j > 82 && j < 101) || (i > 1 && i < 10 && j > 12 && j < 35) || 
                        (i > 3 && i < 10 && j > 86 && j < 99) || (i > 15 && i < 20 && j > 15 && j < 41) || (i > 12 && i < 15 && j > 68 && j < 83) || (i == 27 && j > 3 && j < 18) || 
                        (i > 14 && i < 28 && j > 49 && j < 56) || (i == 12 && j < 30)) return false;           
            else return true;
        }
        public bool FinishLabirynth() 
        {
            int j = Position.X;
            int i = Position.Y;
            if (Position.X == 70 && Position.Y == 1)
            {
                return true;                
            }
            else return false;
        }
        public void CorrectLabirynth() 
        {
            Console.Clear();
            Console.SetCursorPosition((Console.LargestWindowWidth - 40) / 2, (Console.LargestWindowHeight - 10) / 2);
            Console.WriteLine(" Fantastycznie Ci poszło! ");
            Console.SetCursorPosition((Console.LargestWindowWidth - 98) / 2, (Console.LargestWindowHeight - 8) / 2);
            Console.WriteLine(" Dostałeś się już niemal na scenę, wystrczy tylko otworzyć klapę, wspiąć się i Twój cel będzie na wyciągnięcie ręki... ");
            Console.SetCursorPosition((Console.LargestWindowWidth - 40) / 2, (Console.LargestWindowHeight - 6) / 2);
            Console.WriteLine(" Ukończyłeś 2. zadanie! ");
            Console.ReadKey();
            game.TheEnd(Console.LargestWindowWidth, Console.LargestWindowHeight);
            End.Win();
        }
    }
    public enum Direction { Left, Right, Up, Down, None }
}
