using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayRotation
{
    class ArrayHelper
    {
        public static int[] InputNumberArray()
        {
            Console.WriteLine("Enter No. of element");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("===============================");
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void ArrayReversePrint()
        {
            int[] arr = InputNumberArray();
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public static void ArrayReverse()
        {
            int[] arr = InputNumberArray();
            for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
            {
                var temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
            PrintArray(arr);
        }

        public static void ArrayRotation()
        {
            int[] arr = ArrayHelper.InputNumberArray();

            Console.WriteLine("Enter how many items you want to swap");
            int d = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < d; i++)
            {
                int temp = arr[0];
                int j;
                for (j = 0; j < arr.Length - 1; j++)
                {
                    arr[j] = arr[j + 1];
                }
                arr[j] = temp;
            }

            Console.WriteLine("Rotated array is:\n");
            PrintArray(arr);
        }
    }
}
