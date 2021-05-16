using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQ
{
    public class Array_1
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

        #region Print Union And Intersection of Two Given Arrays
        public static void Print_Union_Intersection_OfArrays_TwoLoops_BruteForce() //Brute Force O(n*n)
        {
            var a1 = CreateArray();
            var a2 = CreateArray();

            int lengthUarr = a1.Length + a2.Length;
            int[] u = new int[lengthUarr];
            Array.Copy(a1, u, a1.Length);

            int count = 0;
            int i = a1.Length;
            Console.WriteLine("===============Array Inersection==================");
            while (i < u.Length && count < a2.Length)
            {
                if (Array.IndexOf(u, a2[count]) == -1) // order of Array.IndexOf is O(n)
                {
                    u[i] = a2[count];
                    i++;
                }
                else
                {
                    Console.Write($"{a2[count]} ");
                }
                count++;
            }

            Console.WriteLine("\n===============Array Union=======================");
            PrintArray(u);
        }

        /// <summary>
        /// Handles duplicates
        /// </summary>
        public static void Print_Union_Intersection_OfArrays_UsingHashSet()
        {
            var a1 = CreateArray();
            var a2 = CreateArray();

            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < a1.Length; i++)
            {
                set.Add(a1[i]);
            }
            Console.WriteLine("===============Array Inersection==================");
            for (int j = 0; j < a2.Length; j++)
            {
                if (!set.Add(a2[j]))
                {
                    Console.Write($"{a2[j]} ");
                }
            }

            Console.WriteLine("\n===============Array Union=======================");
            foreach (var value in set)
            {
                Console.Write($"{value} ");
            }
        }

        /// <summary>
        /// Not handle duplicates.
        /// </summary>
        public static void Print_Union_Intersection_OfArrays_Using_Sorting_And_BinarySearch()
        {
            var a1 = CreateArray();
            var a2 = CreateArray();

            // Before finding union intersection, make sure a1 is smaller
            if (a1.Length > a2.Length)
            {
                int[] temp = a1;
                a1 = a2;
                a2 = temp;
            }

             
            Array.Sort(a1);
            Array.Sort(a2);

            //Copy sorted samll array to union array
            var u = new int[a1.Length + a2.Length];
            Array.Copy(a1, u, a1.Length);

            //Union of both the arrays
            // Search every element of bigger array in smaller array and print the element if not found 
            int index = a1.Length;
            for (int i = 0; i < a2.Length; i++)
            {
                if (BinarySearch(a1, a2[i]) == -1)
                {
                    u[index++] = a2[i];
                }
            }

            Console.WriteLine("Union if arrays : ");
            PrintArray(u);

            //Intersection of both the arrays
            // Search every element of bigger array in smaller array and print the element if  found 
            Console.WriteLine("Intersection of arrays : ");
            for (int i = 0; i < a2.Length; i++)
            {
                if (BinarySearch(a1, a2[i]) != -1)
                {
                    Console.Write(a2[i]);
                }
            }
        }

        private static int BinarySearch(int[] a, int item)
        {
            int lb = 0;
            int ub = a.Length - 1;
            int mid;
            while (ub >= lb)
            {
                mid = (lb + ub) / 2;
                if (a[mid] == item)
                {
                    return 1;
                }
                else if (a[mid] > item)
                    ub = mid - 1;
                else
                    lb = mid + 1;
            }
            return -1;
        }
        #endregion

        #region Second Largest
        public static void SecondLargestElement_BruteForce()
        {
            var arr = CreateArray();

            //first = second = INT_MIN;
            var largest = 0;
            var sLargest = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largest) // If array element greater than largest
                {
                    sLargest = largest;
                    largest = arr[i];
                }

                if (arr[i] > sLargest && arr[i] < largest) //If array element is between Largest and Second Largest
                    sLargest = arr[i];
            }

            Console.WriteLine($"Largest: {largest}");
            if (sLargest == 0)
                Console.WriteLine("The second largest does not exist");
            else
                Console.WriteLine($"Second Largest: {sLargest}");
        } //Best Approach O(n)

        public static void SecondLargest_TraverseArrayTwice() // O(2n)
        {
            var arr = CreateArray();

            int first = 0;
            int second = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > first)
                    first = arr[i];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < first && arr[i] > second)
                    second = arr[i];
            }

            if (first == second)
                Console.WriteLine("The second largest does not exist");
            else
                Console.WriteLine($"Second Largest: {second}");
        }
        #endregion Second Largest

        #region Move All Zeros To End
        /// <summary>
        /// We need to maintain the order of non-zero elements.
        /// </summary>
        public static void MoveAllZerosToEnd_WithCopyingNonZeroElementsToNewArray()  //Expansive solution because of extra space
        {
            var arr = CreateArray();
            var length = arr.Length;

            var newArray = new int[length];
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] != 0)
                    newArray[count++] = arr[i];
            }

            while (count < length)
                newArray[count++] = 0;

            PrintArray(newArray);
        }

        /// <summary>
        /// Push forward non zeros elements, than add remaining zeros to the end.
        /// </summary>
        public static void MoveAllZerosToEnd_TwoTraverseButInSameArray()//O(n) and without extra spac 
        {
            var arr = CreateArray();
            var length = arr.Length;

            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] != 0)
                    arr[count++] = arr[i];
            }

            while (count < length)
                arr[count++] = 0;

            PrintArray(arr);
        }

        /// <summary>
        /// Best Solution O(n) and Nice Technique.
        /// </summary>
        public static void MoveAllZerosToEnd_SingleTraverseInSameArray() //best solution O(n)
        {
            var a = CreateArray();
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                    SwapNumbers(ref a[count++], ref a[i]);
            }

            PrintArray(a);
        }

        public static void MoveAllZerosToEnd_WithSortingDescendingOrder()//n*logn 
        {
            var a = CreateArray();
            //int count = 0;

            //Array.Sort()
        } 
        #endregion

        #region Move All Odd Numbers To End
        public static void MoveAllOddNumbersToEnd_UsingSwapping_SingleTraverse()
        {
            var a = CreateArray();
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    SwapNumbers(ref a[count++], ref a[i]);
                }
            }
            PrintArray(a);
        }
        #endregion

        #region Rearrange positive and negative numbers
        public static void RearrangePositive_And_Negative_Numbers()
        {
            var a = CreateArray();
            int count = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                    SwapNumbers(ref a[count++], ref a[i]);
            }
            PrintArray(a);
        }
        #endregion

        #region Rearrange positive and negative numbers in alternative fashion with O(1) space whitout preserving order
        /// <summary>
        /// A C# program to put positive numbers at even indexes (0, 2, 4, ..) 
        /// and negative numbers at odd indexes (1, 3, 5, ..) 
        /// 
        /// Does not maintain the order of array elements
        /// </summary>
        public static void RearrangePositive_And_Negative_Numbers_AlternativeFashion() //Medium
        {
            var a = CreateArray();
            int count = 0;

            //Segregating negative numbers at left and positives numbers at right side of an array.
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < 0)
                    SwapNumbers(ref a[count++], ref a[i]);
            }
            PrintArray(a);

            // Now all positive numbers are at end and negative numbers at the beginning of array. 
            // Initialize indexes for starting point of positive and negative numbers to be swapped
            int pos = count;
            int neg = 0;

            // Increment the negative index by 2 and 
            // positive index by 1, i.e., swap every  
            // alternate negative number with next positive number
            while (pos < a.Length && pos > neg && a[neg] < 0)
            {
                int temp = a[neg];
                a[neg] = a[pos];
                a[pos] = temp;
                pos++;
                neg += 2;
            }
            Console.WriteLine("Postive and Negative numbers i alternative fashion");
            PrintArray(a);
        }

        /// <summary>
        /// O(1) space with preserving the order 
        /// </summary>
        public static void RearrangePositive_And_Negative_Numbers_AlternativeFashion_WithPreservingOrder() //Hard
        {

        }
        #endregion

        #region Segregate 0's and 1's in an array

        public static void Segregate_0_And_1_InAn_Array_Count_0_Fill_0_And_1()
        {
            var a = CreateArray();

            // counts the no of zeros in arr 
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                    count++;
            }

            // loop fills the arr with 0 until count 
            for (int i = 0; i < count; i++)
                a[i] = 0;

            // loop fills remaining arr space with 1 
            for (int i = count; i < a.Length; i++)
                a[i] = 1;

            PrintArray(a);
        }
        public static void Segregate_0_And_1_InAn_Array_UsingSwapping()
        {
            var a = CreateArray();

            int index = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == 0)
                {
                    SwapNumbers(ref a[index++], ref a[i]);
                }
            }

            PrintArray(a);
        }

        /// <summary>
        /// Dutch National Flag with 2 pointers(Left and Right) O(n)
        /// </summary>
        public static void Segregate_0_And_1_In_An_Array_Dutch_National_Flag()
        {
            var a = CreateArray();
            int left = 0;
            int right = a.Length - 1;

            while (left < right)
            {
                // Increment left index while we see 0 at left
                while (a[left] == 0 && left < right)
                    left++;

                //Decrement right index while we see 1 at right
                while (a[right] == 1 && left < right)
                    right--;

                if(left < right)
                {
                    a[left] = 0;
                    a[right] = 1;
                    left++;
                    right--;
                }
            }
            PrintArray(a);
        }

        #endregion

        #region Segregate 0's, 1's and 2's in an array
        public void Segregate_0_1_And_2_Count_0_Fill_0_And_1() { }

        /// <summary>
        /// Dutch National Flag with 3 pointers(Left, Right and Mid) O(n)
        /// https://www.coderbyte.com/algorithm/dutch-national-flag-sorting-problem
        /// </summary>
        public static void Segregate_0_1_And_2_Dutch_National_Flag()
        {
            var a = CreateArray();

            var low = 0;
            var mid = 0;
            var high = a.Length - 1;

            // one pass through the array swapping the necessary elements in place
            while (mid <= high)
            {
                if (a[mid] == 0) { SwapNumbers(ref a[low++], ref a[mid++]); }
                else if (a[mid] == 2) { SwapNumbers(ref a[mid], ref a[high--]); }
                else if (a[mid] == 1) { mid++; }
            }

            PrintArray(a);
        }
        #endregion

        #region Count Frequencies of all elements
        /// <summary>
        /// Having nice technique to remember dupicates element's index, So no need to trverse them.
        /// Saving lot of iteration for the repeated values of an array.
        /// </summary>
        public static void CountFrequencis_BruteForceTwoLoops() // Having nice technique(Visiting Array).
        {
            var a = CreateArray();
            var length = a.Length;
            var visitedArray = new bool[length];

            for (int i = 0; i < length; i++)
            {
                if (visitedArray[i] == true)
                    continue;

                int count = 1;
                for (int j = i + 1; j < length; j++)
                {
                    if (a[i] == a[j])
                    {
                        count++;
                        visitedArray[j] = true;
                    }
                }

                Console.WriteLine($"{a[i]} {count}");
            }
        }

        public static void CountFrequencis_UsingHashMap()
        {
            var a = CreateArray();
            var d = CreateDictionary(a);

            foreach (var item in d)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }
        #endregion

        #region Delete Duplicate from Array
        public static void DeleteDuplicates_UsingHashMap() //Not good, Hashset is good to use 
        {
            var a = CreateArray();
            var d = CreateDictionary(a);

            foreach (var item in d)
            {
                if (item.Value > 1)
                    Console.WriteLine($"Duplicate: {item.Key}");
            }
        }

        public static void DeleteDuplicates_UsingHashSet()
        {
            var a = CreateArray();
            foreach (var i in CreateHashSet(a))
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Best Solution or sorted array -  O(n) O(1) 
        /// </summary>
        public static void DeleteDuplicates_SortedArray_TwoPointerTechnque()//O(n) O(1)
        {
            var a = CreateArray();
            Array.Sort(a);

            int i = 0;
            for (int j = 1; j < a.Length; j++)
            {
                if (a[j] != a[i])
                {
                    i++;
                    a[i] = a[j];
                }
            }
            
            for (int k = 0; k <= i; k++)
            {
                Console.WriteLine(a[k]);
            }
        }
        #endregion

        #region Majority Element
        /// <summary>
        /// A majority element in an array A[] of size n is an element that appears more than n/2 times 
        /// (and hence there is at most one such element).
        /// </summary>
        public static void MajorityElement_BruteForceTwoLoops()
        {
            var a = CreateArray();

            int count, maxCount = -1, majElement = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                        count++;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    majElement = a[i];
                }
            }

            if (maxCount > a.Length / 2)
                Console.WriteLine($"{majElement} is Majority Element");
            else
                Console.WriteLine("There is no majority element");

        }
        public static void MajorityElement_UsingHashMap() // Time O(n) space O(n)
        {
            var a = CreateArray();
            Dictionary<int, int> d = new Dictionary<int, int>();

            for (int i = 0; i < a.Length; i++)
            {
                if (!d.ContainsKey(a[i]))
                {
                    d[a[i]] = 1;
                }
                else
                {
                    d[a[i]] += 1;
                    if (d[a[i]] > a.Length / 2)
                        Console.WriteLine($"{a[i]} is a majority element");
                }
            }
        }
        public static void MajorityElement_UsingSorting() // O(nlogn)
        {
            int[] a = CreateArray();
            Array.Sort(a);
            int count = 1, maxCount = -1;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] == a[i])
                    count++;
                else
                {
                    count = 1;
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    if (maxCount > a.Length / 2)
                        Console.WriteLine(a[i]);
                }
            }

            if (maxCount <= a.Length / 2)
                Console.WriteLine("There is no majority element");
        }
        public static void MajorityElement_UsingMoorayVoting() //// Time O(n) space O(1)
        {
            var a = CreateArray();
            var length = a.Length;

            //Step 1: Finding a Candidate
            //The algorithm for the first phase that works in O(n) is known as Moore’s Voting Algorithm.
            //Basic idea of the algorithm is that if each occurrence of an element e can be cancelled with all 
            //the other elements that are different from e then e will exist till end it is a majority element.
            int candidate_index = 0, count = 1;
            for (int i = 1; i < length; i++)
            {
                if (a[candidate_index] == a[i])
                    count++;
                else
                    count--;
                if (count == 0)
                {
                    candidate_index = i;
                    count = 1;
                }
            }

            count = 0;
            //Step 2: Check if the element obtained in step 1 is majority element or not.
            //Traverse through the array and check if the count of the element found is greater than half the size of the array.
            for (int i = 0; i < length; i++)
            {
                if (a[candidate_index] == a[i])
                    count++;
            }

            if (count > length / 2)
                Console.WriteLine($"Majority element : {a[candidate_index]}");
            else
                Console.WriteLine("No Majority element");

        }
        #endregion

        #region Print All The Leaders In The Array
        /// <summary>
        /// An element is leader if it is greater than all the elements to its right side. And the rightmost element is always a leader.
        /// </summary>
        public static void PrintAllTheLeadersInTheArray_ScanFromRight()//another sol is brute force with 2 loops
        {
            var a = CreateArray();
            int length = a.Length;
            int max = a[length - 1];
            Console.Write(max);
            for (int i = length - 2; i >= 0; i--)
            {
                if (a[i] > max)
                {
                    max = a[i];
                    Console.Write($" {max}");
                }
            }
        }
        #endregion

        #region Peak Element
        /// <summary>
        /// An array element is a peak if it is NOT smaller(equal or greater) than its neighbours.
        /// </summary>
        public static void PeakElement_NaiveApproach_PrintAllPeakElements() // O(n) O(1)
        {
            var a = CreateArray();
            var length = a.Length;

            Console.WriteLine("Peak Elements : ");
            if (a[0] >= a[1])
                Console.Write($"{a[0]} ");
            if (a[length - 1] >= a[length - 2])
                Console.Write($"{a[length - 1]} ");

            for (int i = 1; i < length - 1; i++)
            {
                if (a[i] >= a[i - 1] && a[i] >= a[i + 1])
                    Console.Write($"{a[i]} ");
            }
        }

        /// <summary>
        /// 1.  Divide and Conquer can be used to find a peak in O(Logn) time. The idea is based on the 
        /// technique of Binary Search to check if the middle element is the peak element or not.
        /// 2.If the middle element is not the peak element then : 
        /// 3. Check if the element on the left side is greater than the middle element then 
        /// there is always a peak element on the left side.
        /// 4. Check if the element on the right side is greater than the middle element then 
        /// there is always a peak element on the right side.
        /// </summary>
        public static void PeakElement_DivideAndConquer_ReturnOnlyOnePeakElement_Lengthy() //O(logn) O(1)
        {
            var a = CreateArray();
            int len = a.Length;

            if (len == 1)
                Console.WriteLine($"Peak Element : {a[0]}");
            else
            {
                int lb = 0;
                int ub = len - 1;
                int mid = 0;
                while (ub >= lb)
                {
                    mid = (lb + ub) / 2;

                    if (mid == 0)
                    {
                        if (a[mid] >= a[mid + 1])
                        {
                            Console.WriteLine($"Peak Element : {a[mid]}");
                            break;
                        }
                        else
                        {
                            lb = mid + 1;
                            mid = (lb + ub) / 2;
                        }

                    }

                    if (mid == len - 1)
                    {
                        if (a[mid] >= a[len - 1])
                        {
                            Console.WriteLine($"Peak Element : {a[mid]}");
                            break;
                        }
                        else
                        {
                            ub = mid - 1;
                            mid = (lb + ub) / 2;
                        }

                    }

                    if (a[mid] >= a[mid - 1] && a[mid] >= a[mid + 1])
                    {
                        Console.WriteLine($"Peak Element : {a[mid]}");
                        break;
                    }

                    if (a[mid - 1] > a[mid])
                        ub = mid - 1;
                    else
                        lb = mid + 1;
                }
            }

        }

        public static void PeakElement_DivideAndConquer_ReturnOnlyOnePeakElement_MergerdConditions() //O(logn) O(1)
        {
            var a = CreateArray();
            int len = a.Length;

            if (len == 1)
                Console.WriteLine($"Peak Element : {a[0]}");
            else
            {
                int lb = 0;
                int ub = len - 1;
                int mid = 0;
                while (ub >= lb)
                {
                    mid = (lb + ub) / 2;

                    // Compare middle element with its neighbours (if neighbours exist)
                    if ((mid == 0 || a[mid] >= a[mid - 1]) && (mid == len - 1 || a[mid] >= a[mid + 1]))
                    {
                        Console.WriteLine($"Peak Element : {a[mid]}");
                        break;
                    }

                    // If middle element is not peak and its left neighbor is greater than it,
                    //then left half must have a peak element 
                    if (mid > 0 && a[mid - 1] > a[mid])
                        ub = mid - 1;
                    else
                        lb = mid + 1;
                }
            }
        }
        #endregion

        #region Find Pairs For Given Sum with indices for distinct elements, repititve elements and count pairs for given sum 

        /// <summary>
        /// This work if array has distinct elements who are part of pair for given sum, Can't print indices because of HashSet
        /// </summary>
        public static void PairsForGivenSum_UsingHashSet_DontPrintRepititvPairs() //O(n) O(n)
        {
            var a = CreateArray();
            Console.WriteLine("Enter sum : ");
            int sum = Convert.ToInt32(Console.ReadLine());

            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < a.Length; i++)
            {
                int temp = sum - a[i];
                if (set.Contains(temp))
                {
                    Console.WriteLine($"Pair with given sum : ({temp} , {a[i]})");
                }
                else
                    set.Add(a[i]);
            }
        }

        /// <summary>
        /// This work if array has distinct elements who are part of pair for given sum, Print indices 
        /// </summary>
        public static void PairsForGivenSum_UsingTwoPointers_DC_ForSortedArray_DontPrintRepititvPairs() //O(nlogn) O(1)
        {
            var a = CreateArray();
            Console.WriteLine("Enter sum : ");
            int sum = Convert.ToInt32(Console.ReadLine());

            Array.Sort(a);
            int lb = 0;
            int ub = a.Length - 1;

            while (lb < ub)
            {
                if (a[lb] + a[ub] == sum)
                    Console.WriteLine($"pair with given sum : index: ({lb}, {ub}), value: {a[lb]}, {a[ub]})");
                if (a[lb] + a[ub] > sum)
                    ub--;
                else
                    lb++;

                //Trying to handle repetitive elements case----but seems not possible with this approach
                //To print all pairs need to use ---> 1.Brute Force(2 loops) 2.HashMap
                //if (a[lb] + a[ub] == sum)
                //{
                //    Console.WriteLine($"Pair with given sum : Index: ({lb}, {ub}), Value: {a[lb]}, {a[ub]})");
                //}
                //if (a[lb] + a[ub] > sum || (ub < a.Length - 1 && a[lb] + a[ub - 1] == sum))
                //    ub--;
                //else
                //    lb++;
            }
        }

        /// <summary>
        /// This work if array has repetitive elements also, who are part of pair for given sum, Can't print indices because of HashMap
        /// </summary>
        public static void PairsForGivenSum_UsingHashMap_PrintRepititvPairs() //O(m*n) O(n)
        {
            var a = CreateArray();
            Console.WriteLine("Enter sum : ");
            int sum = Convert.ToInt32(Console.ReadLine());

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                int temp = sum - a[i];
                if (dict.ContainsKey(temp))
                {
                    int count = dict[temp];
                    for (int j = 0; j < count; j++)
                    {
                        Console.WriteLine($"Pair with given sum : ({temp} , {a[i]})");
                    }
                }
                if (!dict.ContainsKey(a[i]))
                    dict.Add(a[i], 1);
                else
                    dict[a[i]] += 1;
            }
        }

        /// <summary>
        /// This work if array has repetitive elements also, who are part of pair for given sum, Print indices because of BruteForce
        /// </summary>
        public static void PairsForGivenSum_UsingBruteForce_PrintRepititvPairsWithIndexes() //O(n*c) O(n)
        {
            var a = CreateArray();
            Console.WriteLine("Enter sum : ");
            int sum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 1; j < a.Length; j++)
                {
                    if (a[i] + a[j] == sum)
                    {
                        Console.WriteLine($"pair with given sum : index: ({i}, {j}), value: {a[i]}, {a[j]})");
                    }
                }
            }
        }

        public static void PrintPairsCount_ForGivenSum_UsingHashMap() //O(n) O(n)
        {
            var a = CreateArray();
            Console.WriteLine("Enter sum : ");
            int sum = Convert.ToInt32(Console.ReadLine());

            var dict = CreateDictionary(a);
            int pairsCount = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (dict.ContainsKey(sum - a[i]))
                    pairsCount += dict[sum - a[i]];

                // if (arr[i], arr[i]) pair satisfies  
                // the condition, then we need to ensure  
                // that the count is decreased by one  
                // such that the (arr[i], arr[i])  
                // pair is not considered  
                if (sum - a[i] == a[i])
                {
                    pairsCount--;
                }
            }

            // reduce pairsCount to half because in above process we counted pairs vice-versa
            //(means (1,2) & (2,1) also but it should be only ones)
            Console.WriteLine("Count of pairs is " + pairsCount / 2);
        }

        #endregion

        #region Find Triplets For Given Sum with indices, Similar to Pairs sum. Just wrap same logic inside a for loop
        /// <summary>
        /// Similar to Pairs sum. Just wrap same logic inside a for loop
        /// Same solution for : 
        /// 1. Find a triplet such that sum of two equals to third element
        /// 2. Pythagorean Triplet in an array. Idea is similar to Find a triplet that sum to a given value[Sqaure all Elements]
        /// </summary>
        public static void TripletsForGivenSum_UsingTwoPointers_DC_ForSortedArray_DontPrintRepititveTriplets() //O(nlogn) O(1)
        {
            var a = CreateArray();
            Console.WriteLine("Enter sum : ");
            int sum = Convert.ToInt32(Console.ReadLine());

            Array.Sort(a);
            //Now fix the first element one by one and find the other two elements
            for (int i = 0; i < a.Length - 2; i++)
            {
                // To find the other two elements, start two index variables from
                // two corners of the array and move them toward each other
                int lb = i + 1;
                int ub = a.Length - 1;
                while (lb < ub)
                {
                    if (a[i] + a[lb] + a[ub] == sum)
                        Console.WriteLine($"pair with given sum : index: ({i}, {lb}, {ub}), value: {a[i]}, {a[lb]}, {a[ub]})");
                    if (a[i] + a[lb] + a[ub] > sum)
                        ub--;
                    else
                        lb++;
                }
            }
        }

        /// <summary>
        /// Similar to Pairs sum. Just wrap same logic inside a for loop
        /// Same solution for : 
        ///  1. Find a triplet such that sum of two equals to third element
        ///  2. Pythagorean Triplet in an array. Idea is similar to Find a triplet that sum to a given value[Sqaure all Elements]
        /// </summary>
        public static void TripletsForGivenSum_UsingHashSet_DontPrintRepititvPairs_DontPrintRepititveTriplets() //O(n) O(n)
        {
            var a = CreateArray();
            Console.WriteLine("Enter sum : ");
            int sum = Convert.ToInt32(Console.ReadLine());

            // Fix the first element as A[i] 
            //for (int i = 0; i < a.Length - 2; i++)
            //{
            //HashSet<int> set = new HashSet<int>();
            //int temp1 = sum - a[i];
            //for (int j = i+1; j < a.Length; j++)
            //{
            //    int temp2 = temp1 - a[j];
            //    if (set.Contains(temp2))
            //    {
            //        Console.WriteLine($"Pair with given sum : ({a[i]}, {a[j]}, {temp2})");
            //    }
            //    set.Add(a[j]);
            //}
            //}

            //Nice alterante insted of using two temp1 & temp2 variables, use one only. Fix the first element as A[i] 
            for (int i = 0; i < a.Length - 2; i++)
            {
                HashSet<int> set = new HashSet<int>();
                for (int j = i + 1; j < a.Length; j++)
                {
                    int temp = sum - a[i] - a[j];
                    if (set.Contains(temp))
                    {
                        Console.WriteLine($"Pair with given sum : ({a[i]}, {a[j]}, {temp})");
                    }
                    else
                        set.Add(a[j]);
                }
            }
        }
        #endregion

        #region Maximum Triplet Sum In Array
        public static void MaximumTripletSum_SortArray_addLastTreeElements() // O(nlogn-->Sorting) O(1) 
        {
            var a = CreateArray();
            int n = a.Length;
            Array.Sort(a);

            Console.WriteLine($"Maximum Triplet Sum In Array : {a[n - 1] + a[n - 2] + a[n - 3]}");
        }

        public static void MaximumTripletSum_ScanArray_ComputeMax_SecondMax_ThirdMax_WithoutDuplicates() // O(n) O(1)
        {
            var a = CreateArray();
            int n = a.Length;

            int max1 = a[0];
            int max2 = a[0];
            int max3 = a[0];

            for (int i = 0; i < n; i++)
            {
                if (a[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = a[i];
                }

                else if (a[i] > max2 && a[i] < max1)
                {
                    max3 = max2;
                    max2 = a[i];
                }
                else if (a[i] > max3 && a[i] < max2)
                {
                    max3 = a[i];
                }
            }

            if (max1 == max2 && max1 == max3)
                Console.WriteLine("All elements are same in given array");
            else if (max1 != max2 && max2 == max3)
                Console.WriteLine("Array does not contain third maximum");
            else
                Console.WriteLine($"Maximum Triplet Sum In Array : {max1 + max2 + max3}");
        }
        #endregion

        #region Largest Three Elements In An Array
        public static void LargestThreeElementsInArray_ScanArray_ComputeMax_secondMAx_ThirdMax() // O(n) O(1)
        {
            var a = CreateArray();
            int n = a.Length;

            int max1 = a[0];
            int max2 = a[0];
            int max3 = a[0];

            for (int i = 0; i < n; i++)
            {
                if (a[i] > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = a[i];
                }

                else if (a[i] > max2 && a[i] < max1)
                {
                    max3 = max2;
                    max2 = a[i];
                }
                else if (a[i] > max3 && a[i] < max2)
                {
                    max3 = a[i];
                }
            }

            if (max1 == max2 && max1 == max3)
                Console.WriteLine("All elements are same in given array");
            else if (max1 != max2 && max2 == max3)
                Console.WriteLine("Array does not contain third maximum");
            else
                Console.WriteLine($"Largest three elements in Array : {max1},  {max2}, {max3}");
        }

        public static void LargestThreeElementsInArray_SortArray_Print_LastTreeElements_WithHandlingDuplicates() // O(nlogn-->Sorting) O(1) 
        {
            var a = CreateArray();
            int n = a.Length;
            Array.Sort(a);

            int check = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (count < 4)
                {
                    if (check != a[n - i - 1])
                    {
                        // to handle duplicate values 
                        Console.Write(a[n - i - 1] + " ");
                        check = a[n - i - 1];
                        count++;
                    }
                }
                else
                {
                    if (count == 1)
                        Console.WriteLine("All Elements are same");
                    else if (count == 2)
                        Console.WriteLine("Third maximum element is not present in the array");
                    break;
                }

            }

        }

        #endregion

        #region Kth Largest Element
        public static void KthLargestElement_SortingMethod_HandlingDuplicates() // O(nlogn) O(1)
        {
            Console.WriteLine("Enter which element you want to find : ");
            var k = Convert.ToInt32(Console.ReadLine());
            var a = CreateArray();
            int n = a.Length;
            Array.Sort(a);

            int check = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (count < k)
                {
                    if (check != a[n - i - 1])
                    {
                        //check variable we are using to handle duplicate values 
                        check = a[n - i - 1];
                        count++;
                    }
                }
                if (count == k)
                {
                    Console.Write($"{k}th largest element : {a[n - i - 1]}  ");
                    break;
                }
            }
            if(count < k)
                Console.WriteLine($"{k}th largest number not found in the array");
        }

        public static void KthLargestElement_UsingMinHeap_HeapSelect() //O(n + kLogn) O(n)
        {

        }

        public static void KthLargestElement_UsingMaxHeap() // O(k + (n-k)*Logk)
        {
        }

        /// <summary>
        /// The worst case time complexity of this method is O(n2), but it works in O(n) on average.
        /// https://www.geeksforgeeks.org/kth-smallestlargest-element-unsorted-array-set-3-worst-case-linear-time/
        /// 
        /// </summary>
        public static void KthLargestElement_QuickSelectUsingQuickSort() { }
        #endregion

        #region Check if array elements are consecutive

        public static void FindConsecutiveArray_WithSorting()
        {

        }

        public static void FindConsecutiveArray_WithVisitedArray()
        {

        }
        #endregion

        //https://medium.com/dev-genius/microsoft-interview-tasks-max-inserts-to-obtain-string-without-3-consecutive-a-36769aa70daf
        public static void FindMAxOccurence()
        {
            string s = Console.ReadLine();
            int count_As = 0, count_others = 0, s_len = s.Length;
            for (int i = 0; i < s_len; ++i)
            {
                if (s[i] == 'a')
                {
                    count_As++;
                }
                else
                {
                    count_others++;
                    count_As = 0;
                }
                if (count_As == 3)
                {
                    Console.WriteLine(-1);
                }
            }
            Console.WriteLine(2 * (count_others + 1) - (s_len - count_others));
        }
    }
}
