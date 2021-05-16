using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingQ
{
    public class DynamicProgramming
    {
        #region Nth Fibonacci Number
        public static int NthFibonacciNumber_Recursive(int n)
        {
            if(n==0 || n == 1)
            {
                return n;
            }

            return NthFibonacciNumber_Recursive(n - 1) + NthFibonacciNumber_Recursive(n - 2);
        }

        public static int NthFibonacciNumber_TopDownDP(int n, int[] a)
        {
            if (n == 0 || n == 1)
            {
                a[n] = n;
                return n;
            }

            //Already Computed
            if (a.Contains(n))
            {
                return a[n];
            }
            else
            {
                //Compute and store it
                a[n] = (NthFibonacciNumber_TopDownDP(n - 1, a) + NthFibonacciNumber_TopDownDP(n - 2, a));
                return a[n];
            }
        }

        public static int NthFibonacciNumber_BottomUpDP_Iterative(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 1;


            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

        public static int NthFibonacciNumber_BottomUpDP_Optimized(int n)
        {
            int a = 0, b = 1;
            int c = 0;
            for (int i = 2; i <= n ; i++)
            {
                c = a + b;
                a = b;
                b = c
;
            }

            return c;
        }
        #endregion

        #region Total no of ways to reach top of the ladder 
        public static int TotalWaysToTopOfLadder_Recursive(int n)
        {
            //1, 2 and 3 jumps we can take at a time

            if (n == 0)
                return 1;

            if (n < 0)
                return 0;

            int ans = TotalWaysToTopOfLadder_Recursive(n - 1) + TotalWaysToTopOfLadder_Recursive(n - 2) 
                + TotalWaysToTopOfLadder_Recursive(n - 3);
            return ans;
        }

        public static int TotalWaysToTopOfLadder_TopDowbDP(int n, int[] dp)
        {
            //1, 2 and 3 jumps we can take at a time

            if (n == 0)
            {
                dp[0] = 1;
                return 1;
            }
                
            if (n < 0)
            {
                return 0;
            }

            //Already Computed
            if (dp.Contains(n))
            {
                return dp[n];
            }
            else
            {
                //Compute and store it
                dp[n] = TotalWaysToTopOfLadder_TopDowbDP(n - 1, dp) + TotalWaysToTopOfLadder_TopDowbDP(n - 2, dp) 
                    + TotalWaysToTopOfLadder_TopDowbDP(n - 3, dp);
                return dp[n];
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">no of ladders</param>
        /// <param name="k">maximum jumps we can take</param>
        /// <returns></returns>
        public static int TotalWaysToTopOfLadder_Ways2(int n, int k)
        {
            if (n == 0)
                return 1;
            if (n < 0)
                return 0;

            int ans = 0;
            for (int j = 1; j <= k; j++)
            {
                ans += TotalWaysToTopOfLadder_Ways2(n - j, k);
            }

            return ans;
        }

        public static int TotalWaysToTopOfLadder_BottomUpDP(int n, int k)
        {
            int[] dp = new int[n + 1];
            dp[0] = 1;

            for (int step = 1; step <= n; step++)
            {
                dp[step] = 0;
                for (int j = 1; j <= k; j++)
                {
                    if (step-j >= 0)
                    {
                        dp[step] += dp[step - j];
                    }
                }
            }
            return dp[n];
        }
        #endregion
    }
}
