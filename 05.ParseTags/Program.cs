using System;

namespace _05.ParseTags
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/05.%20Parse%20tags/README.md
            //input
            string input = Console.ReadLine();
            string upStrStart = "<upcase>";
            string upStrEnd = "</upcase>";
            char[] inputAsChar = input.ToCharArray();
            //calculation
            ConvertToUpper(input, upStrStart, upStrEnd, inputAsChar);
            string result = new string(inputAsChar);
            result = result.Replace(upStrStart, "");
            result = result.Replace(upStrEnd, "");
            //print
            Console.WriteLine(result);
        }

        private static void ConvertToUpper(string input, string upStrStart, string upStrEnd, char[] inputAsChar)
        {
            int indexStart = -1;
            int indexEnd = -1;
            for (int i = 0; i < input.Length; i++)
            {
                indexStart = input.IndexOf(upStrStart, indexStart + 1);
                if (indexStart != -1)
                {
                    indexEnd = input.IndexOf(upStrEnd, indexEnd + 1);
                    for (int j = indexStart + upStrStart.Length; j < indexEnd; j++)
                    {
                        string temp = input[j].ToString().ToUpper();
                        inputAsChar[j] = Convert.ToChar(temp);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
