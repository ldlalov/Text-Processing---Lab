using System;
using System.Collections.Generic;


namespace _04._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] banned = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (string s in banned)
            {
                text = text.Replace(s, new string('*',s.Length));
            }
            Console.WriteLine(text);
        }
    }
}
