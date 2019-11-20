using System;
using System.Collections.Generic;
using System.Text;

namespace Spojovy_seznam
{
    class MujList<T>
    {
        private Node FirstNode { get; set; }
        public MujList()
        {
            FirstNode = null; 
        }
        public void Add(T v)
        {
            var Novy = new Node() { Value = v, Next = FirstNode };
            FirstNode = Novy;
        }
        public void Remove()
        {
            if (FirstNode != null)
            {
                FirstNode = FirstNode.Next;
            }
        }

        public void Insert(T v, int n)
        {
            var Help = FirstNode;
            var pointer = 0;
            if (n == 0)
            {
                Add(v);
            }
            else
            {
                while (pointer < n - 1)
                {
                    Help = Help.Next;
                    pointer++;
                }
                var Novy = new Node() { Value = v, Next = Help.Next };
            }
        }
        public override string ToString()
        {
            string res = "";
            Node pointer = FirstNode;
            while (pointer != null)
            {
                res += "\n" + pointer.Value.ToString();
                pointer = pointer.Next;                
            }
            return res;
        }
        internal class Node
        {
            public T Value { get; set; }
            public Node Next { get; set; }
        }
    }
}
