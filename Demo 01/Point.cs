using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point(int _x, int _y)
        {
            X = _x;
            Y = _y;
        }

        override public string ToString()
        {
            return $"({X}, {Y})";
        }

        public int CompareTo(Point? other)
        {
            if (other is not null)
            {
                if(X == other?.X) return Y.CompareTo(other.Y);
                return X.CompareTo(other?.X);
            }
            return 1;
        }

        #region non generic CompareTo

        //public int CompareTo(object? obj)
        //{
        //    if (obj is not null)
        //    {
        //        Point P = obj as Point;
        //        if (X == P.X) return Y.CompareTo(P.Y);
        //        return X.CompareTo(P.X);
        //    }
        //    return 1;
        //}

        //public int CompareTo(object? obj)
        //{
        //    if (obj is not null)
        //    {
        //        if (obj is Point point)
        //        {
        //            if (X == point.X) return Y.CompareTo(point.Y);
        //            return X.CompareTo(point.X);
        //        }
        //    }
        //    return 1;

        //}

        #endregion
    }
}
