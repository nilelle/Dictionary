using System;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1, "Bora");
            myDictionary.Add(2, "Istanbul");
            Console.WriteLine(myDictionary.Count);
        }
    }
}
