using System;

namespace _04.Sub_stringInText
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/04.%20Sub-string%20in%20text/README.md
            //input
            string subString = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();
            //calc
            int counter = 0;
            int index = -1;
            for (int i = 0; i < text.Length; i++)
            {
                index = text.IndexOf(subString, index + 1);
                if (index == -1)
                {
                    break;
                }
                else
                {
                    counter++;
                }
            }
            //print
            Console.WriteLine(counter);
        }
    }
}
