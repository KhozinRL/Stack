using System;
using System.Text;

namespace Stack
{
    public class Stack<T> where T : ICloneable
    {
        Node<T> top;

        private class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Value { get; set; }
        }

        public void Push(T element) {
            if (element is not null) {
                Node<T> node = new Node<T>() { Value = element };

                if (top is not null)
                    node.Next = top;
                top = node;
            }
        }

        public T Pop() {
            if (top is not null)
            {
                T result = top.Value;
                top = top.Next;
                return result;
            }
            else {
                throw new Exception("Стек пуст!");
            }
        }

        public T Top() {
            if (top is not null)
                return (T)top.Value.Clone();
            else
            {
                throw new Exception("Стек пуст!");
            }
        }

        public int Count() {
            Node<T> cursor = top;
            int result = 0;
            while (cursor != null) {
                ++result;
                cursor = cursor.Next;
            }
            return result;
        }

        public void Print()
        {
            if (top is null)
            {
                Console.WriteLine("Стек пуст!");
                return;
            }

            Node<T> cursor = top;
            StringBuilder sb = new StringBuilder("Стек: ");

            while (cursor != null)
            {
                sb.AppendFormat("{0}, ", cursor.Value);
                cursor = cursor.Next;
                if (cursor == null)
                {
                    sb.Remove(sb.Length - 2, 2);
                    sb.Append(".");
                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
