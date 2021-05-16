using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQ
{
    public class Array_2
    {
        #region Helper Methods
        public static int[] CreateArray()
        {
            Console.WriteLine("How many elements you wants in the array");
            int length = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[length];
            Console.WriteLine($"Enter {length} elements:");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("================================================");
            return arr;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.WriteLine("================================================");
        }

        public static void SwapNumbers(ref int x, ref int y)
        {
            int temp;

            temp = x;
            x = y;
            y = temp;
        }

        public static Dictionary<int, int> CreateDictionary(int[] a)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!d.ContainsKey(a[i]))
                    d[a[i]] = 1;
                else
                    d[a[i]] += 1;
            }
            return d;
        }

        public static IEnumerable<int> CreateHashSet(int[] a)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (!set.Add(a[i]))
                    yield return a[i];
            }

        }
        #endregion

        #region Find the Missing Number. Array has distinct elements

        public static void MissingNumber_SumamtionFormula_ForDistinctElements()
        {
            var a = CreateArray();
            float lastValue = a[a.Length - 1];

            //int summation = lastValue * ((lastValue + 1) / 2); // This won't work properly because of roundiog off
            int summation = Convert.ToInt32(lastValue * ((lastValue + 1) / 2));
            for (int i = 0; i < a.Length; i++)
            {
                summation -= a[i];
            }
            Console.WriteLine($"Missing Number : {summation}");
        }

        /// <summary>
        /// The approach remains the same but there can be overflow if n is large. In order to avoid integer overflow, 
        /// pick one number from known numbers and subtract one number from given numbers. 
        /// This way there won’t have Integer Overflow ever.
        /// </summary>
        public static void MissingNumber_Sumamtion_With_ModificationForOverflow_ForDistinctElements()
        {
            var a = CreateArray();

            int total = 1;
            for (int i = 2; i <= (a.Length + 1); i++)
            {
                total += i;
                total -= a[i - 2];
            }
            Console.WriteLine($"Missing Number : {total}");
        }

        /// <summary>
        /// XOR has certain properties
        /// Assume a1 ^ a2 ^ a3 ^ …^ an = a and a1 ^ a2 ^ a3 ^ …^ an-1 = b Then a ^ b = an  
        /// 
        /// Using this property, the missing element can be found. Calculate XOR of all the natural number from 1 to n 
        /// and store it as a. Now calculate XOR of all the elements of the array and store it as b. The missing number will be a ^ b.
        /// </summary>
        public static void MissingNumber_XOR_ForDistinctElements()
        {
            var a = CreateArray();

            int x1 = a[0];
            int x2 = 1;

            /* For xor of all the elements  
            in array */
            for (int i = 1; i < a.Length; i++)
            {
                x1 = x1 ^ a[i];
                Console.WriteLine(x1);
            }


            /* For xor of all the elements  
            from 1 to n+1 */
            for (int i = 2; i <= a.Length + 1; i++)
                x2 = x2 ^ i;

            var missingNo = (x1 ^ x2);
            Console.WriteLine($"Missing Number : {missingNo}");
        }

        /// <summary>
        /// In this method we need sorted array O(n)
        /// </summary>
        public static void MissingNumber_IfDifferenceIsMoreThan1_For_Sorted_And_Distinct_Array()//O(n) Linear Search
        {
            var a = CreateArray();
            int n = a.Length;

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i + 1] - a[i] > 1)
                {
                    Console.WriteLine($"Missing Number : {a[i] + 1}");
                    return;
                }
            }
            Console.WriteLine($"No Missing Number");
        }

        public static void MissingNumber_Sorted_2_Pointers_SearchFromBothTheSides() { }

        /// <summary>
        /// Not Correct https://www.geeksforgeeks.org/find-the-missing-number-in-a-sorted-array/?ref=rp
        /// I modified it (Below solution is only for nos > 0.)
        /// </summary>
        public static void MissingNumber_Using_DC_and_Sorting_ForDistinctElements() //O(log n) Binary Search
        {
            int[] a = CreateArray();
            int lb = 0;
            int ub = a.Length - 1;
            int mid = 0;
            
            while (lb < ub)
            {
                mid = (lb + ub) / 2;
                if (a[mid] - a[mid - 1] != 1)
                {
                    Console.WriteLine($"Missing no is: {a[mid] - 1}");
                    break;
                }
                else if (a[mid + 1] - a[mid] != 1)
                {
                    Console.WriteLine($"Missing no is: {a[mid] + 1}");
                    break;
                }

                if (a[mid] - mid > 1)
                    ub = mid;
                else if (a[ub] - ub > 1)
                    lb = mid;
            }
        }
        #endregion

        #region Find the Missing Number. Array has Repititive elements also
        public static void MissingNumber_Sumamtion_ForDistinctAndRepititveElements()
        {
            var a = CreateArray();
            int n = a.Length;
            float lastValue = a[n - 1];

            int summation = Convert.ToInt32(lastValue * ((lastValue + 1) / 2));
            for (int i = 0; i < n; i++)
            {
                if (i < n - 1 && a[i] != a[i + 1])
                    summation -= a[i];
                else if (i == n - 1)
                    summation -= a[i];
            }
            Console.WriteLine($"Missing Number : {summation}");
        }

        public static void MissingNumber_Hashing_For_Sorted_And_BothDistintAndRepititie()
        {
            var a = CreateArray();
            int n = a.Length;

            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                set.Add(a[i]);
            }

            // index value set to 1  
            int index = 1;

            // Return the first value starting from 1 which does not exists in map  
            while (index <= set.Count)
            {
                if (!set.Contains(index))
                {
                    Console.WriteLine($"Missing Number : {index}");
                }
                index++;
            }
        }
        #endregion

        #region Find the minimum distance between two numbers
        public static void MinimumDistaneBetweenTwoNumbwer_BruteForce()
        {
            var a = CreateArray();
            int n = a.Length;
            Console.WriteLine("Enter first number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int y = Convert.ToInt32(Console.ReadLine());

            int min_dist = 32000;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x || a[i] == y)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (a[i] != a[j] && (a[j] == x || a[j] == y))
                        {
                            min_dist = Math.Abs(Math.Min(min_dist, j - i));
                        }
                    }
                }
            }

            Console.WriteLine($"Minimium distance : {min_dist}");
        }

        public static void MinimumDistaneBetweenTwoNumbwer_StoringPreviousVisitedIndex() //Nice Technique O(n) O(1)
        {
            var a = CreateArray();
            int n = a.Length;
            Console.WriteLine("Enter first number : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number : ");
            int y = Convert.ToInt32(Console.ReadLine());

            int min_dist = 32000;
            int prevIndex = -1;
            for (int i = 0; i < n; i++)
            {
                if (a[i] == x || a[i] == y)
                {
                    if (prevIndex != -1 && a[prevIndex] != a[i])
                    {
                        //min_dist = min_dist > i - prevIndex ? i - prevIndex : min_dist;
                        if (i - prevIndex < min_dist)
                            min_dist = i - prevIndex;
                    }
                    prevIndex = i;
                }
            }

            Console.WriteLine($"Minimium distance : {min_dist}");
        }
        #endregion

        #region Find minimum difference between any two elements
        public static void MinimumDifferenceBetweenAnyTwoElements_BruteForce()

        {

        }

        public static void MinimumDifferenceBetweenAnyTwoElements_Sorting()
        {
            var a = CreateArray();
            int n = a.Length;
            Array.Sort(a);

            int min_diff = int.MaxValue;
            for (int i = 0; i < n - 1; i++)
            {
                if (a[i + 1] - a[i] < min_diff)
                    min_diff = a[i + 1] - a[i];
            }

            Console.WriteLine($"minimum difference between any two elements : {min_diff}");
        }
        #endregion

        #region 
        #endregion
    }
}
