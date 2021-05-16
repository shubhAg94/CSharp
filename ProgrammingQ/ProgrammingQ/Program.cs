using System;
using System.Linq;

namespace ProgrammingQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "this_is_a_variable";
            //str.Contains('_');
            //string[] arr = str.Split('_');

            //for (int i = 1; i < arr.Length; i++)
            //{
            //    arr[i] = arr[i][0].ToString().ToUpper();
            //}

            //var res = arr.Join('');
            //Console.WriteLine(res);

        #region Array_1 Problems



        //Array_1.SecondLargestElement_BruteForce();

        //Array_1.SecondLargest_TraverseArrayTwice();

        //Array_1.MoveAllZerosToEnd_WithCopyingNonZeroElementsToNewArray();

        //Array_1.MoveAllZerosToEnd_TwoTraverseButInSameArray();

        //Array_1.MoveAllZerosToEnd_SingleTraverseInSameArray();

        //Array_1.MajorityElement_UsingHashMap();

        //Array_1.MajorityElement_UsingSorting();

        //Array_1.MajorityElement_BruteForceTwoLoops();

        //Array_1.MajorityElement_UsingMoorayVoting();

        //Array_1.CountFrequencis_BruteForceTwoLoops();

        //Array_1.CountFrequencis_UsingHashMap();

        //Array_1.DeleteDuplicates_UsingHashMap();

        //Array_1.DeleteDuplicates_UsingHashSet();

        //Array_1.DeleteDuplicates_SortedArray_WithExtraSpace();

        //Array_1.DeleteDuplicates_SortedArray_WithConstantSpace();

        //Array_1.MoveAllOddNumbersToEnd_UsingSwapping_SingleTraverse();

        //Array_1.RearrangePositive_And_Negative_Numbers();

        //Array_1.PrintAllTheLeadersInTheArray_ScanFromRight();

        //Array_1.Print_Union_Intersection_OfArrays_TwoLoops_BruteForce();

        //Array_1.Print_Union_Intersection_OfArrays_UsingHashSet();

        //Array_1.Print_Union_Intersection_OfArrays_Using_Sorting_And_BinarySearch();

        //Array_1.RearrangePositive_And_Negative_Numbers_AlternativeFashion();

        //Array_1.Segregate_0_And_1_InAn_Array_UsingSwapping();

        //Array_1.Segregate_0_And_1_InAn_Array_Using_NaiveApp_Count_0_And_1();

        //Array_1.Segregate_0_And_1_In_An_Array_Dutch_National_Flag();

        //Array_1.Segregate_0_1_And_2_Dutch_National_Flag();

        //Array_1.PeakElement_NaiveApproach_PrintAllPeakElements();

        //Array_1.PeakElement_DivideAndConquer_ReturnOnlyOnePeakElement_Lengthy();

        //Array_1.PeakElement_DivideAndConquer_ReturnOnlyOnePeakElement_MergerdConditions();

        //Array_1.PairsForGivenSum_UsingHashSet_DontPrintRepititvPairs();

        //Array_1.PairsForGivenSum_UsingHashMap_PrintRepititvPairs();

        //Array_1.PairsForGivenSum_UsingTwoPointers_DC_ForSortedArray_DontPrintRepititvPairs();

        //Array_1.PairsForGivenSum_UsingHashMap_PrintRepititvPairs();

        //Array_1.PrintPairsCount_ForGivenSum_UsingHashMap();

        //Array_1.TripletsForGivenSum_UsingTwoPointers_DC_ForSortedArray_DontPrintRepititveTriplets();

        //Array_1.TripletsForGivenSum_UsingHashSet_DontPrintRepititvPairs_DontPrintRepititveTriplets();

        //Array_1.MaximumTripletSum_ScanArray_ComputeMax_SecondMax_ThirdMax_WithoutDuplicates();

        //Array_1.LargestThreeElementsInArray_ScanArray_ComputeMax_secondMAx_ThirdMax();

        //Array_1.LargestThreeElementsInArray_SortArray_Print_LastTreeElements_WithHandlingDuplicates();


        //Array_1.KthLargestElement_SortingMethod_HandlingDuplicates();

        https://medium.com/dev-genius/microsoft-interview-tasks-max-inserts-to-obtain-string-without-3-consecutive-a-36769aa70daf
              // Array_1.FindMAxOccurence();

            #endregion

            #region Array_2 Problems
            //Array_2.SmallestMissingNumber_LinearSearch();

            //Array_2.MissingNumber_IfDifferenceIsMoreThan1_ForDistinctElements();

            //Array_2.MissingNumber_SumamtionFormula();

            //Array_2.MissingNumber_XOR_ForDistinctElements();

            //Array_2.MissingNumber_Using_DC_and_Sorting_ForDistinctElements();

            //Array_2.MissingNumber_Sumamtion_ForDistinctAndRepititveElements();

            //Array_2.MissingNumber_Hashing_For_Sorted_And_BothDistintAndRepititie();

            //Array_2.Find_N_MissingNumbers_Using_VisitedArray();

            //Array_2.MinimumDistaneBetweenTwoNumbwer_BruteForce();

            //Array_2.MinimumDistaneBetweenTwoNumbwer_StoringPreviousVisitedIndex();

            //Array_2.MinimumDifferenceBetweenAnyTwoElements_Sorting();
            #endregion

            #region DP Problems
            //Console.WriteLine(DynamicProgramming.NthFibonacciNumber_Recursive(5));

            //int[] dp = new int[100];
            //Console.WriteLine(DynamicProgramming.NthFibonacciNumber_TopDownDP(5, dp));

            //Console.WriteLine(DynamicProgramming.NthFibonacciNumber_BottomUpDP_Iterative(5));

            //Console.WriteLine(DynamicProgramming.NthFibonacciNumber_BottomUpDP_Optimized(5));

            //Console.WriteLine(DynamicProgramming.TotalWaysToTopOfLadder_Recursive(4));

            //int[] dp = new int[100];
            //Console.WriteLine(DynamicProgramming.TotalWaysToTopOfLadder_TopDowbDP(4, dp));

            //Console.WriteLine(DynamicProgramming.TotalWaysToTopOfLadder_Ways2(4, 3));
            //Console.WriteLine(DynamicProgramming.TotalWaysToTopOfLadder_Ways2(5, 4));

            //Console.WriteLine(DynamicProgramming.TotalWaysToTopOfLadder_BottomUpDP(4, 3));
            //Console.WriteLine(DynamicProgramming.TotalWaysToTopOfLadder_BottomUpDP(5, 4));

            #endregion

            #region Graph
            //Graph.CreteGraph_WitjAdjacencyMatrix();

            //GraphAjdacencyMatrix graph = new GraphAjdacencyMatrix(5);
            //graph.AddEdge(0, 1);
            //graph.AddEdge(0, 4);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(1, 3);
            //graph.AddEdge(1, 4);
            //graph.AddEdge(2, 3);
            //graph.AddEdge(3, 4);
            //graph.PrintGraph();

            //GraphAdjacencyList.CreateListGraph();
            //GraphAdjacencyList.CreateDictionaryGraph();

            //var vertices = new string[] { "Agra","Amritsar","Bangalore","Delhi","Jaipur", "Siachen"};
            //GenericGraphD<string> genericGraph = new GenericGraphD<string>(vertices);
            //genericGraph.AddEdge("Amritsar", "Delhi");
            //genericGraph.AddEdge("Amritsar", "Jaipur");
            //genericGraph.AddEdge("Delhi", "Siachen");
            //genericGraph.AddEdge("Delhi", "Bangalore");
            //genericGraph.AddEdge("Delhi", "Agra");
            //genericGraph.AddEdge("Amritsar", "Siachen");

            //genericGraph.PrintGenericGraph();

            //var vertices = new int[] { 0, 1, 2, 3, 4, 5 };
            //GraphAdjListUsingDictionary graph = new GraphAdjListUsingDictionary(vertices);
            //graph.AddEdge(0, 1);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(0, 4);
            //graph.AddEdge(2, 4);
            //graph.AddEdge(3, 2);
            //graph.AddEdge(2, 3);
            //graph.AddEdge(3, 4);
            //graph.AddEdge(3, 5);

            //graph.Bfs(0);
            //graph.Bfs_FindDistances(0);
            //graph.Bfs_ShortestPath(0, 5);

            //var boardVertices = new int[36];
            //for (int i = 0; i < boardVertices.Length; i++)
            //{
            //    boardVertices[i] = i;
            //}
            //GraphUsingDictionary graph = new GraphUsingDictionary(boardVertices);
            //graph.SnakeLadder_ShortestPath(graph);

            //GraphUsingList graph = new GraphUsingList(37);
            //graph.SnakeLadder_ShortestPath(graph);

            #endregion

            #region String - 1
            //String_1.Print_Permutations();

            //String_1.AreAnagram("geeksforgeeks", "forgeeksgeeks");
            #endregion
            Console.ReadKey();
        }
    }
}
