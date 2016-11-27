using System;
using System.Threading;
using System.Globalization;

namespace _10.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {  //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/10.%20Unicode%20characters/README.md
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //input
            string input = Console.ReadLine();
            //calculation and print
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u{0:X4}", (int)input[i]);  //ако форматиращия низ({0:X4}), който превръща int-та в 16-чна, да добавя метод на превръщане на числа Deci -> Hexadecimal и да върна ресултата
            }
            Console.WriteLine();
        }
    }
}
