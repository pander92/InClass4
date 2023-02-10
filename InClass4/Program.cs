using System;

namespace MyNameSpace
{
    interface MyInterface
    {
        string ScreamToTheVoid { get; set; }
    }

    interface IndexInterface<T>
    {
        T this[int i] { get; set; }
    }

    class MyClass: MyInterface, IndexInterface<int>
    {
        private string alpha = "Beyonce";
        private int beta = 45;
        private List<string> omega;
        private int[] arr = new int[100];

        public string ScreamToTheVoid
        {
            get { return "AHHHHHHHHH!"; }
            set { ScreamToTheVoid = value; }
        }

        public int this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }

        public string Alpha
        {
            get { return alpha; }
            set { alpha = value; }
        }

        public int Beta
        {
            get { return beta; }
            set { beta = value; }
        }

        public List<string> Omega
        {
            get { return omega; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var exampleOne = new MyClass();
            exampleOne[0] = 11;

            Console.WriteLine(exampleOne[0]);

        }
    }
}

