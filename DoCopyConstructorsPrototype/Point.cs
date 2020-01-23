using System;

namespace DoCopyConstructorsPrototype
{
    [Serializable]
    public class Point
    {
        public int X, Y;

        public Point()
        {
            
        }
        
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point DeepCopy()
        {
            return new Point(X, Y);
        }

        public override string ToString()
        {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
        }
    }
}