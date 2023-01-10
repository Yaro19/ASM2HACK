using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM2HACK
{
    public static class StringPowerUp
    {
        /// <summary>
        /// Converts a decimal string value in binary
        /// </summary>
        /// <param name="decString"></param>
        /// <returns></returns>
        public static string ToBinary(this string decString)
        {

            string decItem = decString;

            string binItem = "";
            int result = Int32.Parse(decItem);

            if (decItem.StartsWith('0'))
            {
                return "0";
            }

            while (result != 0)
            {
                binItem = binItem + (result % 2).ToString();
                result = result / 2;
            }

            return binItem.ReverseString();
        }

        /// <summary>
        /// Returns reversed string
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ReverseString(this string value)
        {
            string reversed = "";

            for (int i = value.Length - 1; i >= 0; i--)
            {
                reversed = reversed + value[i];
            }

            return reversed;
        }

        /// <summary>
        /// Appends a char at the beginning of a string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string AppendCharAtStringBegin(this string value, char c)
        {
            string result = "";

            result += c;

            for (int i = 0; i < value.Length; i++)
            {
                result += value[i] ;
            }

            return result;

        }

        /// <summary>
        /// Returns logic AND between value and secondArg, but 
        /// secondArg must be longer (or equal to) than value.
        /// ARGUMENTS MUST BE BINARY DIGIT
        /// Result is from right to left binary digit string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="secondArg"></param>
        /// <returns></returns>
        public static string LogicANDstring(this string value, string secondArg)
        {
            string result = "";

            if(secondArg.Length < value.Length)
            {
                return "\nValue is longer than secondArg\n";
            }

            for (int i = 0; i < secondArg.Length; i++)
            {
                if (value.Length > i)
                {
                    result += LogicANDchar(value[i], secondArg[i]);
                }
                else
                {
                    result = result.AppendCharAtStringBegin(LogicANDchar(secondArg[i], '0'));
                }
                
            }

            return result;
        }

        public static char LogicANDchar(this char value, char secondArg)
        {
            char result = '0';

            if(value == '1' && value == secondArg)
            {
                result = '1';
            }

            return result;
        }

        /// <summary>
        /// Removes all chars after c (argument), if the string 
        /// does not contain c then it returns the same string
        /// </summary>
        /// <param name="value"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string RemoveAfter(this string value, char c)
        {
            if (value.Contains(c))
            {
                int index = value.IndexOf(c);

                string removedCstring = value.Remove(index);

                return removedCstring;
            }
            else
            {
                return value;
            }
        }

        public static string RemoveBefore(this string value, char c)
        {
            string temp = "";

            if (value.Contains(c))
            {
                for (int i = value.Length-1; i >= 0; i--)
                {
                    if (value[i] != c)
                    {
                        temp += value[i];
                    }
                    else
                    {
                        break;
                    }               
                }

                return temp.ReverseString();
            }
            else
            {
                return value;
            }
        }
    }
}
