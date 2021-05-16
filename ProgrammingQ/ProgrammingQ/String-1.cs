using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQ
{
    public class String_1
    {
        public static string InputString()
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            Console.WriteLine("================================================");
            return str;
        }

        public static string SwapCharacters (string str, int i, int j)
        {
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }

        public static void Print_Permutations()
        {
            string str = InputString();
            Permute(str, 0, str.Length - 1);
        }

        public static void Permute(string str, int left, int right)
        {
            if (left == right)
                Console.WriteLine(str);
            else
            {
                for (int i = left; i <= right; i++)
                {
                    str = SwapCharacters(str, left, i);
                    Permute(str, left + 1, right);
                    str = SwapCharacters(str, left, i);
                }
            }
        }

        public static bool AreAnagram(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            int NO_OF_CHARS = 256;
            // Create 2 count arrays and initialize
            // all values as 0
            int[] count1 = new int[NO_OF_CHARS];

            // For each character in input strings,
            // increment count in the corresponding
            // count array
            for (int i = 0; i < str1.Length && i < str2.Length; i++)
            {
                count1[str1[i]]++;
            }

            // Compare count arrays
            for (int i = 0; i < NO_OF_CHARS; i++)
            {
                if (count1[i] != 0)
                {
                    return false;
                }
            }
                
            return true;
        }
    }
}
