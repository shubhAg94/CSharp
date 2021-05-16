using System;
using System.Collections.Generic;
using System.Text;

namespace DS
{
    public class MyStack
    {
        private readonly List<int> list = null;

        public MyStack()
        {
            list = new List<int>();
        }
        public void Push(int data)
        {
            list.Add(data);
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public void Pop()
        {
            if (!IsEmpty())
            {
                list.RemoveAt(list.Count-1);
            }
        }

        public int Top()
        {
            return list[list.Count-1];
        }
    }
}
