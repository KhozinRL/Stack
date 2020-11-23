using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Integer> stack = stackInit<Integer>();
            stack.Print();
            Console.WriteLine("Количество элементов в стеке: {0}", stack.Count());
            Console.WriteLine();

            for (int i = 0; i < 2; i++) {
                Console.WriteLine("Стек Pop(): {0}", stack.Pop());
                stack.Print();
                Console.WriteLine("Количество элементов в стеке: {0}", stack.Count());
                Console.WriteLine();
            }

            Console.WriteLine("Стек Top(): {0}", stack.Top());
            stack.Print();
            Console.WriteLine("Количество элементов в стеке: {0}", stack.Count());
            Console.WriteLine();

            stack.Push(new Random().Next(0, 100));
            Console.WriteLine("Стек Push({0})", stack.Top());
            stack.Print();
            Console.WriteLine("Количество элементов в стеке: {0}", stack.Count());

        }

        public static Stack<T> stackInit<T>() where T : ICloneable, new() {
            Stack<T> stack = new Stack<T>();
            
            for (int i = 0; i < 10; i++)
            {
                stack.Push(new T());
            }
            return stack;
        }

    }
}
