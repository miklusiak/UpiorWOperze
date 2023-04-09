using System;
using System.Collections.Generic;
using System.Text;

namespace UpiorWOperze
{
    public class Move
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Move()
        {
            X = 1;
            Y = 6;
        }
        public Move(int x, int y)
        {
            X = x;
            Y = y;
        }       
    }
}
