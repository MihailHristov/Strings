using System;

namespace _06.StringLength
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/06.%20String%20length/README.md
            //input
            string input = Console.ReadLine();
            //calculation
            char[] inputAsChar = new char[20];
            for (int i = 0; i < inputAsChar.Length; i++)
            {
                if (i < input.Length)
                {
                    inputAsChar[i] = input[i];
                }
                else
                {
                    inputAsChar[i] = '*';
                }
            }
            //print
            Console.WriteLine(inputAsChar);
        }
    }
}
