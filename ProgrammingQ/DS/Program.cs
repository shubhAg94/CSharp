using System;
using System.Collections.Generic;

namespace DS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkList
            //Node head = new Node(3);
            //head = LinkList.InsertAtHead(head, 2);
            //head = LinkList.InsertAtHead(head, 1);
            //head = LinkList.InsertAtHead(head, 0);

            //head = LinkList.InsertInMiddle(head, 5, 2);
            //head = LinkList.InsertInMiddle(head, 10, 6);
            //LinkList.InsertAtTail(head, 15);

            //head = LinkList.DeleteFromStart(head);
            //Console.WriteLine(LinkList.Search(head, 5));
            //LinkList.Print(head);

            //Taking Input
            //Console.WriteLine("How many items you want to insert into LinkList");
            //int length = Convert.ToInt32(Console.ReadLine());
            //Node head = null;
            //for (int i = 0; i < length; i++)
            //{
            //    head = LinkList.InsertAtHead(head, Convert.ToInt32(Console.ReadLine()));
            //}

            //for (int i = 0; i < length; i++)
            //{
            //    head = LinkList.InsertAtTail(head, Convert.ToInt32(Console.ReadLine()));
            //}
            //LinkList.Print(head);

            //Console.WriteLine("\nReversed LinkList:");
            //head = LinkList.ReverseLL_Iteratively(head);
            //LinkList.Print(head);

            //LinkList.KthNodeFromEnd(head, 4);

            //LinkList.MidPoint(head);

            //LL: 1->2->3->4->5.next = 3
            //head.next.next.next.next.next = head.next.next;

            //LL: 1->2->3->4->5 --> Loop: 4->3
            //head.next.next.next.next = head.next.next;

            //var isCycleDetected = LinkList.CycleDetection(head);
            //Console.WriteLine($"\nisCycleDetected: {isCycleDetected}");

            //LinkList.DetectAndRemoveCycle(head);
            //Console.WriteLine($"\nisCycleDetected: {LinkList.CycleDetection(head)}");
            //LinkList.Print(head);
            #endregion

            #region Stack
            //MyStack stack = new MyStack();
            //for (int i = 1; i <= 5; i++)
            //{
            //    stack.Push(i);
            //}

            ////Try to print the content of the stack by popping each element
            //while (!stack.IsEmpty())
            //{
            //    Console.WriteLine(stack.Top());
            //    stack.Pop();
            //}

            //Stack<int> s = new Stack<int>();
            //s.Push(1);
            //s.Push(2);
            //s.Push(3);
            //s.Push(4);

            //StackProblems.ReverseStack(s);
            //while(s.Count > 0)
            //{
            //    Console.WriteLine(s.Pop());
            //}

            //var res = StackProblems.IsParanthesisBalanced("((a+b)+(c-d+f))");
            //Console.WriteLine($"IsParanthesisBalanced: {res}");
            //var res1 = StackProblems.IsParanthesisBalanced("{(a+b)}+[c-d+f]");
            //Console.WriteLine($"IsParanthesisBalanced: {res1}");
            #endregion
        }
    }
}
