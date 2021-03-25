using System;

namespace HomeWork4_1
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }

        public Node() { }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }

    //泛型链表类
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;

        public GenericList()
        {
            tail = head = null;
        }

        public Node<T> Head
        {
            get => head;
        }

        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }

        public static void ForEach(GenericList<T> list,Action<T> action)
        {
            Node<T> n = new Node<T>();
            n = list.head;
            while(n != null)
            {
                action(n.Data);
                n = n.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 整型List
            GenericList<int> intlist = new GenericList<int>();
            for (int x = 0; x < 10; x++)
            {
                intlist.Add(x);
            }
            void PrintMethod<T>(T t)
            {
                Console.WriteLine(t);
            }

            GenericList<int>.ForEach(intlist, PrintMethod);
            int sum = 0;
            int max = 0;
            int min = 0;
            GenericList<int>.ForEach(intlist, m => sum += m);
            GenericList<int>.ForEach(intlist, n => { if (max < n) max = n; });
            GenericList<int>.ForEach(intlist, p => { if (min > p) min = p; });
            Console.WriteLine("sum="+sum);
            Console.WriteLine("max="+max);
            Console.WriteLine("min=" + min);
            Console.ReadKey();

        }

    }
}

