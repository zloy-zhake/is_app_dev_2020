using System;

namespace lec2_code
{
    public class Vertex3D_tostring : Vertex3D
    {
        public Vertex3D_tostring() : base()
        {
        }

        public Vertex3D_tostring(double x, double y, double z) : base(x, y, z)
        {
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}
