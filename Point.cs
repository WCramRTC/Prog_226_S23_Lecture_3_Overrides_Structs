using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_226_S23_Lecture_3_Overrides_Structs
{
    // struct
    internal struct Point
    {
        int _x;
        int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            int x = p1.X + p2.X;
            int y = p1.Y + p2.Y;

            return new Point(x, y);

        }

        public static bool operator >(Point p1, Point p2)
        {
            return p1.X > p2.X;
        }

        public static bool operator <(Point p1, Point p2)
        {
            return p1.X < p2.X;
        }

        public int X { get => _x; set => _x = value; }
        public int Y { get => _y; set => _y = value; }

        public override string ToString()
        {
            return $"X: {X} - Y: {Y}";
        }
    }
}
