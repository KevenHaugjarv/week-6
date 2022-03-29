using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnme
            //programm kuvab kasutaja eesnime pikkuse

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();

            //int firstNameLenghth = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit");

        }
    }
}
