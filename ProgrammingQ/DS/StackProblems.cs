using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class StackProblems
    {
        #region Problems
        /// <summary>
        /// Method 1: Using 2 stack--> Copy given stack to satck2, then stack2 to stack3, finally copy stack3 to given stack
        /// 
        /// Method 2: Using 1 stack-->
        /// </summary>
        public static void ReverseStack(Stack<int> s1)
        {
            //Helper Stack
            Stack<int> s2 = new Stack<int>();
            int n = s1.Count;

            for (int i = 0; i < n; i++)
            {
                //Pick the element at top & insert it at the bottom
                int x = s1.Peek();
                s1.Pop();

                //Transfer n-i-1 elements from stack s1 to s2
                Transfer(s1, s2, n - i - 1);

                //Insert the element x in s1
                s1.Push(x);

                //Transfer n-i-1 elements from stack s2 to s1
                Transfer(s2, s1, n - i - 1);
            }
        }

        public static bool IsParanthesisBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                //If the exp[i] is a starting bracket then push it
                if (input[i] == '(' || input[i] == '{' || input[i] == '[' )
                    stack.Push(input[i]);

                //If exp[i] is an ending bracket then pop from stack and check if the popped bracket is a matching pair
                if (input[i] == ')' || input[i] == '}' || input[i] == ']')
                {
                    //If we see an ending bracket without a pair then return false
                    if (stack.Count == 0)
                        return false;
                    else if (!IsMatchingBracket(stack.Pop(), input[i]))
                        return false;
                }
            }

            if (stack.Count == 0)
                return true;
            else
                return false;
        }
        #endregion

        #region Helper Methods

        private static void Transfer(Stack<int> s1, Stack<int> s2, int n)
        {
            for (int i = 0; i < n; i++)
            {
                s2.Push(s1.Peek());
                s1.Pop();
            }
        }

        private static bool IsMatchingBracket(char popedBracket, char inputBracket)
        {
            if (popedBracket == '(' && inputBracket == ')')
                return true;
            else if (popedBracket == '{' && inputBracket == '}')
                return true;
            else if (popedBracket == '[' && inputBracket == ']')
                return true;
            else
                return false;
        }

        #endregion
    }
}
