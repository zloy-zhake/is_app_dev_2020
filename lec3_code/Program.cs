using System;

namespace lec3_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Айқын емес типтеу (var)
            // var x = 13;
            // var myNums = new double[] { 1.0, 1.5, 2.0, 2.5, 3.0 };
            // var myObj = new MyType();
            // MyVeryLongLongLongType mvlObj1 = new MyVeryLongLongLongType();
            // var mvlObj2 = new MyVeryLongLongLongType();

            // Console.WriteLine("x, Type: {0}", x.GetType());
            // Console.WriteLine("myNums, Type: {0}", myNums.GetType());
            // Console.WriteLine("myObj, Type: {0}", myObj.GetType());
            // Console.WriteLine("mvlObj1, Type: {0}", mvlObj1.GetType());
            // Console.WriteLine("mvlObj2, Type: {0}", mvlObj2.GetType());

            // =====

            // Типтерді runtime кезінде тексеру(dynamic)

            // Person p = new Person() { Id = 1, Name = "Ben", Address = "Redmond, WA" };

            // Company c = new Company() { Id = 1313, Name = "Microsoft", IsBig = true };

            // var v = new { Id = 13, Name = "Widget", Silly = true };

            // PrintInfo(p);
            // PrintInfo(c);
            // PrintInfo(v);

            // try
            // {
            //     PrintInfo(13);
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Упс... PrintInfo(13) шақыруға болмайды");
            //     Console.WriteLine(ex);
            // }

            // =====

            // Көп өлшемді массивтер

            // int[,] mArray1 = new int[,]
            // {
            //     {1,2,3,4},
            //     {5,6,7,8},
            //     {9,10,11,12}
            // };

            // float val1 = mArray1[0, 1]; // 2
            // Console.WriteLine("mArray1[0, 1] == {0}\n", val1);

            // int[][] mArray2 = new int[3][];
            // mArray2[0] = new int[] { 1, 2, 3 };
            // mArray2[1] = new int[] { 4, 5, 6, 7, 8 };
            // mArray2[2] = new int[] { 9, 10, 11, 12 };

            // int val2 = mArray2[2][2]; //11
            // Console.WriteLine("mArray2[2, 2] == {0}\n", val2);

            // =====

            // кеңейту әдістер

            // for (int i = 0; i < 100; ++i)
            // {
            //     if (i.IsPrime())
            //     {
            //         Console.WriteLine(i);
            //     }
            // }

            // =====

            // Default параметрлер

            // методты әдетті жолмен (позиционалды аргументтер) шақыруға болады
            PrintOrderDetails("Gift Shop", 31, "Red Mug");

            // аталған аргументтерті кез келген ретімен беруге болады
            PrintOrderDetails(orderNum: 31, productName: "Red Mug", sellerName: "Gift Shop");
            PrintOrderDetails(productName: "Red Mug", sellerName: "Gift Shop", orderNum: 31);

            // аталған аргументтер мен позиционалды аргументтерді бірге қолдануға болады
            // бірақ олардың реті дұрыс болу керек
            PrintOrderDetails("Gift Shop", 31, productName: "Red Mug");
            PrintOrderDetails(sellerName: "Gift Shop", 31, productName: "Red Mug");
            PrintOrderDetails("Gift Shop", orderNum: 31, "Red Mug");

            // аралас аргументтердің реті дұрыс болмаса - қате
            // PrintOrderDetails(productName: "Red Mug", 31, "Gift Shop");
            // PrintOrderDetails(31, sellerName: "Gift Shop", "Red Mug");
            // PrintOrderDetails(31, "Red Mug", sellerName: "Gift Shop");

            // Default мәндер
            PrintOrderDetails("Gift Shop");
            PrintOrderDetails(sellerName: "Gift Shop");


        }

        static void PrintInfo(dynamic data)
        {
            // Id мен Name property бар нәрселердің бәрін шығарады
            Console.WriteLine("ID: {0}, Name: {1}\n", data.Id, data.Name);
        }

        static void PrintOrderDetails(string sellerName, int orderNum = 10, string productName = "Red Mug")
        {
            Console.WriteLine($"Seller: {sellerName}, Order #: {orderNum}, Product: {productName}");
        }

    }
}
