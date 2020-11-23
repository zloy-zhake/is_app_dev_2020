using System;
using System.Text;

namespace lec9_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // =====
            // Convert a String to Bytes(and Vice Versa)
            // =====

            // string myString = "C# Rocks! өқұ";
            // byte[] bytes = Encoding.ASCII.GetBytes(myString);
            // string restore_from_bytes = Encoding.ASCII.GetString(bytes);
            // byte[] bytes_u = Encoding.Unicode.GetBytes(myString);
            // string restore_from_bytes_u = Encoding.Unicode.GetString(bytes_u);
            // Console.WriteLine("myString: {0}", myString);
            // Console.WriteLine("bytes: {0}", BitConverter.ToString(bytes));
            // Console.WriteLine("restore_from_bytes: {0}", restore_from_bytes);
            // Console.WriteLine("bytes_u: {0}", BitConverter.ToString(bytes_u));
            // Console.WriteLine("restore_from_bytes_u: {0}", restore_from_bytes_u);

            // =====
            // Detect Empty Strings
            // =====

            // string s = null;
            // string s = "";
            // // string s = "\t \t";
            // string s = "abc";

            // Console.WriteLine("IsNullOrEmpty(): {0}", String.IsNullOrEmpty(s));
            // Console.WriteLine("IsNullOrWhitespace(): {0}", String.IsNullOrWhiteSpace(s));

            // =====
            // StringBuilder()
            // =====

            // string a = "Hello";
            // string b = ", ";
            // string c = "World";

            // // string s = a + b + c;

            // string s = a;
            // s = s + b;
            // s = s + c;

            // Console.WriteLine("s: {0}", s);

            // StringBuilder sb = new StringBuilder();
            // sb.Append(a);
            // sb.Append(b);
            // sb.Append(c);

            // Console.WriteLine("sb: {0}", sb);

            // =====
            // Concatenate Collection Items into a String
            // =====

            // int[] vals = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            // string s1 = String.Concat(vals);
            // Console.WriteLine("s1: {0}", s1);

            // string s2 = String.Join(", ", vals);
            // Console.WriteLine("s2: {0}", s2);

            // =====
            // Split()
            // =====

            // string original = "But, in a larger sense, we can not dedicate--we can not consecrate-- we can not hallow--this ground.";
            // char[] delims = new char[] { ' ' };
            // string[] strings = original.Split(delims);
            // Console.WriteLine("Default split behavior:");
            // foreach (string s in strings)
            // {
            //     Console.WriteLine("\t{0}", s);
            // }

            // =====
            // Reverse Words
            // =====

            // string original = "But, in a larger sense, we can not dedicate-- we can not consecrate--we can not hallow-- this ground.";
            // Console.WriteLine("Original: " + original);
            // Console.WriteLine("Reversed: " + Reverse(original));
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
