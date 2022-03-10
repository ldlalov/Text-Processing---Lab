using System;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();
            while (second.Contains(first))
            {
                int firstIndex = second.IndexOf(first);
                second = second.Remove(firstIndex, first.Length);
            }
            Console.WriteLine(second);
        }
    }
}
