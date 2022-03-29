using System;

namespace HOLcounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis mitu h; o; ja l; tähte on lauses "Hello World!"

            Console.WriteLine("Sisesta sõna Hello");
            string wordOne = Console.ReadLine();
            Console.WriteLine("Sisesta sõna world");
            string wordTwo = Console.ReadLine();
            string fullword = $"{wordOne}{wordTwo}".ToLower();
            //Console.WriteLine($"Sinu sõnas on {word.Length} sümbolit");
            int aCounter = 0;
            for (int i = 0; i < fullword.Length; i++)
            {

                if (fullword[i] == 'h')
                {
                    aCounter++;
                }


            }
            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu lauses on {fullword} on {aCounter} 'h' tähte.");
            }
            else
            {
                Console.WriteLine($"Sinu lauses on {fullword} on {aCounter} 'H' täht.");
            }


            for (int i = 0; i < fullword.Length; i++)
            {
                if (fullword[i] == 'o')
                {
                    aCounter++;
                }

            }
            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu lauses on {fullword} on {aCounter} 'o' tähte.");
            }

            for (int i = 0; i < fullword.Length; i++)
            {
                if (fullword[i] == 'l')
                {
                    aCounter++;
                }

            }
            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu lauses on {fullword} on {aCounter} 'l' tähte.");
            }
                
                {
                   
                }
        }

    }
}
