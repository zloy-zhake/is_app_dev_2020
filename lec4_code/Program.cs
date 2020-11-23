using System;
using System.IO;
using System.Collections;

namespace lec4_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // Throw an Exception

            // DoSomething(null);

            // =====

            // Catch an Exception

            // try
            // {
            //     DoSomething(null);
            // }
            // catch (ArgumentNullException ex)
            // {
            //     Console.WriteLine("Exception: " + ex.Message);
            // }

            // =====

            // Catch Multiple Exceptions

            // try
            // {
            //     throw new ArgumentNullException();
            // }
            // catch (ArgumentNullException ex)
            // {
            //     //will not reach here!
            // }
            // catch (ArgumentException ex)
            // {
            //     //will reach here
            // }

            // =====

            // finally

            // StreamWriter stream = null;
            // try
            // {
            //     stream = File.CreateText("temp.txt");
            //     stream.Write(null, -1, 1);
            // }
            // catch (ArgumentNullException ex)
            // {
            //     Console.WriteLine("In catch: ");
            //     Console.WriteLine(ex.Message);
            // }
            // finally
            // {
            //     Console.WriteLine("In finally: Closing file");
            //     if (stream != null)
            //     {
            //         stream.Close();
            //     }
            // }

            // =====

            // Get Useful Information from an Exception

            try
            {
                DivideByZero();
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("ToString(): " + ex.ToString());
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Source: " + ex.Source);
                Console.WriteLine("HelpLink: " + ex.HelpLink);
                Console.WriteLine("TargetSite: " + ex.TargetSite);
                Console.WriteLine("Inner Exception: " + ex.InnerException);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
                Console.WriteLine("Data:");

                if (ex.Data != null)
                {
                    foreach (DictionaryEntry de in ex.Data)
                    {
                        Console.WriteLine("\t{0}: {1}", de.Key, de.Value);
                    }
                }
            }
        }

        static void DoSomething(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("value", "parameter value cannot be null");
            }
        }

        private static void DivideByZero()
        {
            int divisor = 0;
            Console.WriteLine("{0}", 13 / divisor);
        }
    }
}