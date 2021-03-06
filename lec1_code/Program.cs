﻿using System;

namespace lec1_code
{

    public class Vertex3D
    {
        // Constructors
        public Vertex3D()
        {
            _x = _y = _x = 0.0;
        }

        public Vertex3D(double x, double y, double z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        // Fields
        private double _x;
        private double _y;
        private double _z;

        // Properties
        public double X
        {
            get { return _x; }
            set { _x = value; }
        }
        public double Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public double Z
        {
            get { return _z; }
            set { _z = value; }
        }

        // Metods
        public void setToOrigin()
        {
            X = Y = Z = 0.0;
        }

        public void printPoint()
        {
            Console.WriteLine("(" + this.X + ", " + this.Y + ", " + this.Z + ")");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Vertex3D point = new Vertex3D();

            point.printPoint();

            point.X = 5;
            point.Y = 6;
            point.Z = 9;

            point.printPoint();

            point.setToOrigin();
            point.printPoint();
        }
    }
}
