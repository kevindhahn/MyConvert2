using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConvert
{
    public class MyConvert
    {
        public static string IntegerToString(int value)
        {
            string result = System.String.Empty;
            bool isNegative = false;

            if (value < 0)
            {
                isNegative = true;
                value = Math.Abs(value);
            }

            // integers can only be base 10
            int lsv = value % 10;
            do
            {
                // 48 is the ascii code for zero
                int ascii = 48 + lsv;
                char c = (char)ascii;
                result = c.ToString() + result;

                value = value / 10;
                lsv = value % 10;
            }
            while (lsv > 0);

            if (isNegative == true)
            {
                result = "-" + result;
            }

            return result;
        }

        public static int StringToIntegerWithExceptions(string value)
        {
            bool isNegative = false;
            int result = 0;
            int index = 0;

            // Make sure a character exists
            if (value.Length == 0)
            {
                throw new ArgumentOutOfRangeException("value", "Parameter is an empty string");
            }

            // If first character is not valid exit
            if (false == MyConvert.IsValid10(value[0]))
            {
                if (value[0] != 45)
                {
                    throw new ArgumentOutOfRangeException("value", "Parameter starts with invalid character");
                }
                else
                {
                    // If dash then negative number
                    isNegative = true;
                    index++;
                }
            }

            // If valid character loop through characters.
            for (int i = index; i < value.Length; i++)
            {
                char c = value[i];
                if (false == MyConvert.IsValid10(c))
                {
                    throw new ArgumentOutOfRangeException("value", "Parameter contains an invalid character");
                }

                result = (result * 10) + (c - 48);
            }

            // If this was negative add to results
            if (true == isNegative)
            {
                result = result * -1;
            }

            return result;
        }


        public static int StringToInteger(string value)
        {
            bool isNegative = false;
            int result = 0;
            int index = 0;

            // Make sure a character exists
            if (value.Length == 0)
            {
                return result;
            }

            // If first character is not valid exit
            if (false == MyConvert.IsValid10(value[0]))
            {
                if (value[0] != 45) 
                {
                    return result;
                }
                else
                {
                    // If dash then negative number
                    isNegative = true;
                    index++;
                }
            }

            // If valid character loop through characters.
            for (int i = index; i < value.Length; i++)
            {
                char c = value[i];
                if (false == MyConvert.IsValid10(c))
                { 
                    break;
                }

                result = (result * 10) + (c - 48);
            }

            // If this was negative add to results
            if (true == isNegative)
            {
                result = result * -1;
            }

            return result;
        }

        public static bool IsValid10(char c)
        {
            return ((48 <= c) && (c <= 57));
        }

    }
}
