using System;

namespace lec2_code
{
    public class Vertex3D_indexing : Vertex3D
    {
        public Vertex3D_indexing() : base()
        {
        }

        public Vertex3D_indexing(double x, double y, double z) : base(x, y, z)
        {
        }

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return _x;
                    case 1: return _y;
                    case 2: return _z;
                    default:
                        throw new ArgumentOutOfRangeException("index", "Only indexes 0-2 valid!");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: _x = value; break;
                    case 1: _y = value; break;
                    case 2: _z = value; break;
                    default: throw new ArgumentOutOfRangeException("index", "Only indexes 0-2 valid!");
                }
            }
        }

        public double this[string dimension]
        {
            get
            {
                switch (dimension)
                {
                    case "x":
                    case "X": return _x;
                    case "y":
                    case "Y": return _y;
                    case "z":
                    case "Z": return _z;
                    default:
                        throw new ArgumentOutOfRangeException("dimension", "Only dimensions X, Y, and Z are valid!");
                }
            }
            set
            {
                switch (dimension)
                {
                    case "x":
                    case "X": _x = value; break;
                    case "y":
                    case "Y": _y = value; break;
                    case "z":
                    case "Z": _z = value; break;
                    default: throw new ArgumentOutOfRangeException("dimension", "Only dimensions X, Y, and Z are valid!");
                }
            }
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2})", X, Y, Z);
        }
    }
}
