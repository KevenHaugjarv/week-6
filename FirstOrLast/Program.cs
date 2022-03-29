using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada ees ja perekonna nimed
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            int firstNameLength = firstName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} sümbolit.");

            int lastNameLength = lastName.Length;
            Console.WriteLine($"Sinu eesnimes on {lastNameLength} sümbolit.");

            if (firstNameLength < lastNameLength)
            {
                Console.WriteLine("Perekonnanimes on rohkem sümbole");
            }
            else
            {
                Console.WriteLine(" eesnimes on rohkem sümbole");
            }

        }
    }
}
