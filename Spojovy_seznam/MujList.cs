using System;
using System.Collections.Generic;
using System.Text;

namespace Spojovy_seznam
{
    class MujList<T> : IList<T>
    {
        private Node FirstNode { get; set; }
        public bool IsReadOnly { get; set; }
        public T this[int index] 
        {
            get
            {
                var Help = FirstNode;
                for(int i = 0; i <= index; i++)
                {
                    if(i == index)
                    {
                        break;
                    }
                    Help = Help.Next;
                }
                return Help.Value;
            }
            set
            {
                var Help = FirstNode;
                for (int i = 0; i <= index; i++)
                {
                    if (i == index)
                    {
                        break;
                    }
                    Help = Help.Next;
                }
                Help.Value = value;
            }
        }
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
        public void RemoveAt(int position)
        {
            var Help = FirstNode;
            var pointer = 0;
            if (position == 0)
            {
                Remove();
            }
            else
            {
                while (pointer < position)
                {
                    Help = Help.Next;
                    pointer++;
                    if (pointer == position - 1)
                    {
                        Help.Next = Help.Next.Next;
                    }
                }
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
                Help.Next = new Node() { Value = v, Next = Help.Next };
                pointer++;
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
