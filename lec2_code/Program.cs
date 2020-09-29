using System;
using System.Collections;

namespace lec2_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // ToString() example

            // Vertex3D point1 = new Vertex3D(0, 5, 60);
            // Console.WriteLine("point1 = {0}", point1.ToString());

            // Vertex3D_tostring point2 = new Vertex3D_tostring(70, 4, 8);
            // Console.WriteLine("point2 = {0}", point2.ToString());

            // =====

            // Equals() example
            // Vertex3D_equals point1 = new Vertex3D_equals(0, 0, 0);
            // Vertex3D_equals point2 = new Vertex3D_equals(0, 0, 0);
            // Vertex3D_equals point3 = new Vertex3D_equals(10, 11, 12);
            // Console.WriteLine("point1 == point2: {0}", point1.Equals(point2));
            // Console.WriteLine("point2 == point3: {0}", point2.Equals(point3));
            // Console.WriteLine("point3 == point1: {0}", point3.Equals(point1));

            // =====

            // sorting example
            // Vertex3D_compareto point1 = new Vertex3D_compareto(0, 0, 0);
            // Vertex3D_compareto point2 = new Vertex3D_compareto(0, 0, 1);
            // Vertex3D_compareto point3 = new Vertex3D_compareto(1, 0, 0);
            // Vertex3D_compareto point4 = new Vertex3D_compareto(0, 10, 0);
            // ArrayList points = new ArrayList() { point1, point2, point3, point4 };
            // Console.WriteLine("Initial array:");
            // foreach (var point in points)
            // {
            //     Console.Write(point.ToString() + " ");
            // }

            // points.Sort();
            // Console.WriteLine("Sorted array:");
            // foreach (var point in points)
            // {
            //     Console.Write(point.ToString() + " ");
            // }

            // =====

            // indexing example
            // Vertex3D_indexing point1 = new Vertex3D_indexing(75, 15, 4);
            // Console.WriteLine("point = {0}", point1.ToString());
            // Console.WriteLine("point[0] = {0}", point1[0]);
            // Console.WriteLine("point['y'] = {0}", point1["y"]);
            // point1["z"] = 16;
            // Console.WriteLine("point = {0}", point1.ToString());

            // operaror overload example
            Vertex3D_add point1 = new Vertex3D_add(2, 7, 18);
            Vertex3D_add point2 = new Vertex3D_add(1, 2, 3);

            Vertex3D_add point3 = point1 + point2;

            Console.WriteLine("point1 = {0}", point1.ToString());
            Console.WriteLine("point2 = {0}", point2.ToString());
            Console.WriteLine("point3 = {0}", point3.ToString());
        }
    }
}
