using System;

namespace _03.CorrectBrackets
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/03.%20Correct%20brackets/README.md
            char[] input = Console.ReadLine().ToCharArray();
            //calculation
            int bracket1 = 0;
            int bracket2 = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    bracket1++;
                }
                if (input[i] == ')')
                {
                    bracket2++;
                }
            }
            bool correctOrNot = bracket1 == bracket2;
            //print
            Console.WriteLine(correctOrNot ? "Correct" : "Incorrect");
        }
    }
}

//IMPORTANT!!! - The solution is only calculate number of brackets, and if you test with: "(text))text(" , the result will be "Correct", which is NOT correct answer!