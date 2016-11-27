using System;
using System.Text.RegularExpressions;

namespace _15.ReplaceТags
{
    class Program
    {
        static void Main(string[] args)
        {  //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/15.%20Replace%20tags/README.md
            //input
            string input = Console.ReadLine();
            //regular expression
            string output = Regex.Replace(input, @"<a.href=""([^>]*)"">([^<]*(?:(?!</a)<[^<]*)*)</a>", "[$2]($1)");
            //print
            Console.WriteLine(output);
        }
    }
}
