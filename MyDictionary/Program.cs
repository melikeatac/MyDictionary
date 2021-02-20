using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> myDictionary1 = new MyDictionary<string, string>();
            myDictionary1.Add("Melike", "Ataç");
            myDictionary1.Add("Beyza", "Yanar");
            myDictionary1.Add("Dilan", "Çirkin");
            myDictionary1.Add("Büşra", "Bozkuş");

        }
    }
}
