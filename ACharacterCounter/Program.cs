﻿using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajalt sisestada ees- ja perekonnanime
            //programm kuvab mitu a tähte on kasutaja ees ja perekonna nimes kokku

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine().ToLower();
            Console.WriteLine("Sisesta perekonnanimi:");
            string lastName = Console.ReadLine();

            string fullName = $"{firstName}{lastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {
                //Console.WriteLine(firstName[i]);
                if (fullName[i] == 'a')
                {
                    aCounter++;
                }


            }

            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu nimes on {fullName} on {aCounter} 'a' tähte.");
            }

            else
            {
                Console.WriteLine($"Sinu nimes on {fullName} on {aCounter} 'a' täht.");
            }
        }
    }
}
