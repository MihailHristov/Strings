using System;

namespace _02.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/02.%20Reverse%20string/README.md
            string input = Console.ReadLine();

            char[] temp = input.ToCharArray();
            Array.Reverse(temp);
            string reverse = new string(temp);

            Console.WriteLine(string.Join("", reverse));
        }
    }
}
