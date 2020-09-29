using System;

namespace lec2_code
{
    public class Vertex3D_compareto : Vertex3D, IComparable
    {
        public Vertex3D_compareto() : base()
        {
        }

        public Vertex3D_compareto(double x, double y, double z) : base(x, y, z)
        {
        }

        public int CompareTo(object other)
        {
            if (other == null) return 1;

            Vertex3D_compareto other_v3d = other as Vertex3D_compareto;

            // Сравниваем x
            if (this._x < other_v3d._x)
                return -1;
            else if (this._x > other_v3d._x)
            {
                return 1;
            }
            // Сравниваем y
            else if (this._y < other_v3d._y)
            {
                return -1;
            }
            else if (this._y > other_v3d._y)
            {
                return 1;
            }
            // Сравниваем z
            else if (this._z < other_v3d._z)
            {
                return -1;
            }
            else if (this._z > other_v3d._z)
            {
                return 1;
            }
            return 0;
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}
