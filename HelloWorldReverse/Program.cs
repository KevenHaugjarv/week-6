using System;

namespace HelloWorldReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset("Hello World!") tagurpidi

            Console.WriteLine("sisesta lause Hello world:");
            string word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);

            }
        }
    }
}
