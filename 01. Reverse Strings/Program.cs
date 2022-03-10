using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            StringBuilder sb = new StringBuilder();
            while ((input = Console.ReadLine()) != "end")
            {
                char[] cmd = input.ToCharArray();
                char[] newCmd = cmd.Reverse().ToArray();
                sb.Append(newCmd);
                Console.WriteLine($"{input} = {sb}");
                sb.Clear();
            }
        }
    }
}
