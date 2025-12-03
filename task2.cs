    using System;

    class Pair<T, U> where T : class where U : class
    {
        public T First { get; set; }
        public U Second { get; set; }

        public Pair(T first, U second)
        {
            First = first;
            Second = second;
        }

        public void Swap()
        {
            object temp = First;
            First = Second as T;
            Second = temp as U;
        }

        public void Print()
        {
            Console.WriteLine($" {First} / {Second} ");
        }
    }
    class Program
    {
        static void Main()
        {
            Pair<string, string> pair = new Pair<string, string>("бебе", "лала");

            Console.WriteLine("До:");
            pair.Print();
            pair.Swap();
            Console.WriteLine("После:");
            pair.Print();
            Console.ReadLine();
        }
    }
