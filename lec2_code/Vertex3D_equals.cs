using System;

namespace lec2_code
{
    public class Vertex3D_equals : Vertex3D
    {
        public Vertex3D_equals() : base()
        {
        }

        public Vertex3D_equals(double x, double y, double z) : base(x, y, z)
        {
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", X, Y, Z);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != this.GetType())
                return false;
            return Equals((Vertex3D_equals)obj);
        }

        public bool Equals(Vertex3D_equals other)
        {
            return this._x == other._x
            && this._y == other._y
            && this._z == other._z;
        }
    }
}
