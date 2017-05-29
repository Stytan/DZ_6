namespace DZ_6_5
{
    public class Line2D<T>
    {
        public class Point
        {
            private T x;
            private T y;
            public T X { get { return x; } set { x = value; } }
            public T Y { get { return y; } set { y = value; } }
            public Point(T x, T Y)
            {
                this.X = X;
                this.Y = Y;
            }
        }
        private Point p1;
        private Point p2;
        public Point P1 { get { return p1; } set { p1 = value; } }
        public Point P2 { get { return p2; } set { p2 = value; } }
        public Line2D(Point P1, Point P2)
        {
            this.P1 = P1;
            this.P2 = P2;
        }
        public Line2D(T X1, T Y1, T X2, T Y2)
        {
            P1 = new Point(X1, Y1);
            P2 = new Point(X2, Y2);
        }
        public override string ToString()
        {
            return string.Format("[Line2D: P1({0}, {1}), P2({2}, {3})]", P1.X, P1.Y, P2.X, P2.Y);
        }
    }
}
