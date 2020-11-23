using System;
using System.Text.RegularExpressions;

namespace lec10_code
{
    class Program
    {
        static void Main(string[] args)
        {
            // =====
            // Search Text
            // =====

            // string source = "We few, we happy few, we band of brothers...";
            // // Regex regex = new Regex("we");
            // Regex regex = new Regex("[a-zA-Z]{7,}");
            // MatchCollection coll = regex.Matches(source);
            // foreach (Match match in coll)
            // {
            //     Console.WriteLine(
            //         "\t\"{0}\" at position {1}",
            //         match.Value.Trim(),
            //         match.Index
            //     );
            // }

            // =====
            // Extract Groups of Text
            // =====

            // string file = "1234 Cherry Lane, Smalltown, USA" + Environment.NewLine +
            //     "1235 Apple Tree Drive, Smalltown, USA" + Environment.NewLine +
            //     "3456 Smalltown, Cherry Orchard Street, USA" + Environment.NewLine;
            // Regex regex = new Regex("^(?<HouseNumber>\\d+)\\s*(?<Street>[\\w\\s]*), (?<City>[\\w\\s]*), (?<Country>[\\w\\s]+)$", RegexOptions.Multiline);
            // MatchCollection coll = regex.Matches(file);
            // foreach (Match m in coll)
            // {
            //     string street = m.Groups["Street"].Value;
            //     Console.WriteLine("Street: {0}", street);
            // }

            // =====
            // Replace Text
            // =====

            // string source = "We few, we happy few, we band of brothers...";
            // //replace the word after “we” with “something”
            // Regex regex = new Regex("[wW]e\\s[a-zA-Z]+");
            // string result = regex.Replace(source, "we something");
            // Console.WriteLine(result);

            // =====
            // Match and Validate
            // =====

            // Social Security Number

            // string[] userStrings = {
            //     "123456789",
            //     "123-45-6789",
            //     "111-11-1111",
            //     "123-45.678",
            //     "123.45.6789",
            //     "12.123.4444",
            //     "123.45.67890",
            //     "123.a5.6789",
            //     "just random text"
            // };

            // Regex regex = new Regex(@"^\d{3}\-?\d{2}\-?\d{4}$");

            // Phone Number

            // string[] userStrings = {
            //     "123.456.7890",
            //     "123-456-7890",
            //     "1234567890",
            //     "123.4567890",
            //     "12.34.567.890",
            //     "123.456.78900",
            //     "123-456",
            //     "123-abc-7890",
            // };

            // Regex regex = new Regex(
            //     //xxx.xxx.xxxx and xxx-xxx-xxxx
            //     @"^((\d{3}[\-\.]?\d{3}[\-\.]?\d{4})|" +
            //     //xx.xx.xxx.xxx and xx-xx-xxx-xxx
            //     @"(\d{2}[\-\.]?\d{2}[\-\.]?\d{3}[\-\.]?\d{3}))" +
            //     "$"
            // );

            // Dates

            string[] userStrings = {
                "12/25/2009",
                "01/25/2009",
                "1/2/2009",
                "25/12/2009",
                "2009/12/25",
                "13/25/2009",
                "12/25/09",
            };

            Regex regex = new Regex(@"((0[1-9]|1[012])/([1-9]|0[1-9]|[12][0-9]|3[01])/\d{4})");

            foreach (var userString in userStrings)
            {
                bool isMatch = regex.IsMatch(userString);
                Console.WriteLine("{0} ? {1}", userString, isMatch ? "ok" : "bad");
            }
        }
    }
}
