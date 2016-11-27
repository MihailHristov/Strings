using System;

namespace _12.ParseURL
{
    class Program
    {
        static void Main(string[] args)
        { //condition: https://github.com/TelerikAcademy/CSharp-Part-2/blob/master/Topics/06.%20Strings-and-Text-Processing/homework/12.%20Parse%20URL/README.md
            //input
            string input = Console.ReadLine();

            //algorithm
            //get protocol
            int indexProtocol = input.IndexOf(':');
            string protocol = input.Substring(0, indexProtocol);
            input = input.Remove(0, indexProtocol + 3); //remove protocol + ':' and "//" from string
            //get sever
            int indexSever = input.IndexOf('/');
            string server = input.Substring(0, indexSever);
            input = input.Remove(0, indexSever); //remove server from string
            //get resource
            string resource = input;

            //print
            Console.WriteLine("[protocol] = " + protocol);
            Console.WriteLine("[server] = " + server);
            Console.WriteLine("[resource] = " + resource);
        }
    }
}
