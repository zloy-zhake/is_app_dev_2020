using System;

namespace lec2_code
{
    public class Vertex3D_add : Vertex3D
    {
        public Vertex3D_add() : base()
        {
        }

        public Vertex3D_add(double x, double y, double z) : base(x, y, z)
        {
        }

        public static Vertex3D_add operator +(Vertex3D_add a, Vertex3D_add b)
        {
            return new Vertex3D_add(a.X + b.X, a.Y + b.Y, a.Z + b.Z);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}
