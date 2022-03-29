using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab kõik 'o' tähed "Don't Panic" nulliga - 0
            //programm asendab kõik 'a' tähed samas lauses 4-ga

            string PaniC = "Don't Panic";

           
            PaniC = PaniC.Replace('o', '0');
            PaniC = PaniC.Replace('a', '4');
            Console.WriteLine(PaniC);
        }
    }
}
