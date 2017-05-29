using System;

namespace DZ_6_4
{
    /// <summary>
    /// Description of Point3D.
    /// </summary>
    public class Point3D : Point2D<double>
    {
        private object z;
        public object Z
        {
            get { return z; }
            set { z = value; }
        }

        public Point3D() : base()
        {
            Z = default(object);
        }

        public Point3D(object X, object Y, object Z) : base()
        {
            try
            {
                base.X = (double)(int)X;
            }
            catch (InvalidCastException)
            {
                try
                {
                    base.X = (double)(long)X;
                }
                catch (InvalidCastException)
                {
                    try
                    {
                        base.X = (double)(float)X;
                    }
                    catch (InvalidCastException)
                    {
                        base.X = (double)X;
                    }
                }
            }
            try
            {
                base.Y = (double)(int)Y;
            }
            catch (InvalidCastException)
            {
                try
                {
                    base.Y = (double)(long)Y;
                }
                catch (InvalidCastException)
                {
                    try
                    {
                        base.Y = (double)(float)Y;
                    }
                    catch (InvalidCastException)
                    {
                        base.Y = (double)Y;
                    }
                }
            }
            this.Z = Z;
        }
        public override string ToString()
        {
            return string.Format("[Point3D X={0}, Y={1}, Z={2}]", X, Y, Z);
        }
    }
}
