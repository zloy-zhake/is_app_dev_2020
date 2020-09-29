using System;

namespace lec3_code
{
    static class IntMethods
    {
        // кеңейту әдістер static болу керек
        // this кілттік сөз keyword осы әдіс кеңейту әдісі екенін білдіреді
        public static bool IsPrime(this int number)
        {
            if (number % 2 == 0)
            {
                if (number == 2)
                    return true;
                return false;
            }
            int max = (int)Math.Sqrt(number);
            for (int i = 3; i <= max; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}