using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    public class LinkList
    {
        public static void Print(Node head)
        {
            while (head != null)
            {
                Console.Write($"{head.data} ");
                head = head.next;
            }
        }
        public static Node InsertAtHead(Node head, int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return head;
            }

            Node newNode = new Node(data)
            {
                next = head
            };
            head = newNode;
            return head;
        }

        public static Node InsertInMiddle(Node head, int data, int position)
        {
            if (position == 0)
            {
                return InsertAtHead(head, data);
            }
            else if (position > Length(head))
            {
                InsertAtTail(head, data);
            }
            else
            {
                int count = 1;
                Node temp = head;
                while (count != position - 1)
                {
                    temp = temp.next;
                    count++;
                }
                Node newNode = new Node(data)
                {
                    next = temp.next
                };
                temp.next = newNode;
            }
            return head;
        }

        public static Node InsertAtTail(Node head, int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return head;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }

            Node newNode = new Node(data);
            temp.next = newNode;
            return head;
        }

        public static Node DeleteFromStart(Node head)
        {
            if (head == null)
            {
                return null;
            }
            head = head.next;
            return head;
        }

        public static bool Search(Node head, int key)
        {
            if (head == null)
            {
                return false;
            }

            if (head.data == key)
            {
                return true;
            }
            else
            {
                return Search(head.next, key);
            }
        }

        public static Node ReverseLL_Iteratively(Node head)
        {
            Node prev = null;
            Node current = head;
            Node next = null;
            while (current != null)
            {
                //Save the next node
                next = current.next;
                //Make the current node point to previous 
                current.next = prev;

                //Update the previous and current node(Take them one step forward)
                prev = current;
                current = next;
            }
            head = prev;
            return head;
        }

        /// <summary>
        /// Method 1: Find Length then iterate length/2(Pretty obvious) --> O(N) --> Here we are doing 2 iteration
        /// Method 2: Runner technique --> increase fast pointer 2 steps and slow pointer with 1 step --> 1 iteration would be sufficient
        /// --> 
        /// </summary>
        /// <param name="head"></param>
        public static void MidPoint(Node head)
        {
            if (head == null || head.next == null)
            {
                return;
            }

            //Why are we keeping fast = head.next, otherwise we will get 3 as midpoint for 1->2->3->4
            Node fast = head.next;
            Node slow = head;
            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }

            Console.WriteLine($"\n MidPoint: {slow.data}");
        }

        /// <summary>
        /// Method 1: Find length that is N, then we can iterate N-k times from begining
        /// Method 2: We will take fast pointer k steps ahead, From this point onwards we will take both of then one step ahead.
        /// Initiall both(fast and slow pointers are at begining of LL)
        /// </summary>
        /// <param name="head"></param>
        public static void KthNodeFromEnd(Node head, int k)
        {
            if (head == null)
            {
                return;
            }

            if (k > Length(head))
            {
                Console.WriteLine($"\n{Length(head)} is less then {k}");
                return;
            }

            Node fast = head;
            Node slow = head;
            int cnt = 1;
            while (cnt <= k && fast.next != null)
            {
                fast = fast.next;
                cnt++;
            }

            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            Console.WriteLine($"\n{4}th node from end {slow.data}");
        }

        public static bool CycleDetection(Node head)
        {
            Node slow = head;
            Node fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// We need to set null into the next of last nodefor that we need to find that node from where the cycle is starting.
        /// If we get this address then we iterate through entire LL untill the next of any node contains that address.
        /// 
        /// For that floyd given the algorithm --> this is an extension of Cycle Detection algorithm
        /// Algorithm: When slow and fast meets, take the slow pointer to the head of the linklist and keep the fast pointer as it is.
        /// Now they will move one step at a time. Now we will reach at the node where loop starts.
        /// </summary>
        /// <param name="head"></param>
        public static void DetectAndRemoveCycle(Node head)
        {
            Node slow = head;
            Node fast = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;

                if (fast == slow)
                {
                    RemoveCycle(head, fast);
                    return;
                }
            }
        }

        public static void RemoveCycle(Node head, Node loopNode)
        {
            Node ptr1 = head;
            Node ptr2 = null;

            //Now start a pointer from loop_node and check if it ever reaches ptr2
            while (true)
            {
                ptr2 = loopNode;
                while (ptr2.next != ptr1 && ptr2.next != loopNode)
                {
                    ptr2 = ptr2.next;
                }

                if (ptr2.next == ptr1)
                {
                    break;
                }

                ptr1 = ptr1.next;
            }

            //ptr2 is the last node of the loop
            ptr2.next = null;
        }


        public static int Length(Node head)
        {
            int cnt = 0;
            while (head != null)
            {
                head = head.next;
                cnt++;
            }
            return cnt;
        }
    }
}
