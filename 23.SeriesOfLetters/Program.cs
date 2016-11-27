using System;
using System.Text;

namespace _23.SeriesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {  //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/23.%20Series%20of%20letters/README.md
            //input
            string input = Console.ReadLine();
            //calculation
            StringBuilder output = new StringBuilder();
            output.Append(input[0]);
            int lastEqualDigit = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == output[lastEqualDigit])
                {
                    continue;
                }
                else
                {
                    output.Append(input[i]);
                    lastEqualDigit++;
                }
            }
            //print
            Console.WriteLine(output);
        }
    }
}
