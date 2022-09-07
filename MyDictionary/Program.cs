using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
           

            myDictionary.Add(3, "TV");
            myDictionary.Add(4, "Computer");
            myDictionary.Add(231, "Refrigator");
            myDictionary.Add(4,"ismail");
            myDictionary.Show();
            
        }
    }
}
