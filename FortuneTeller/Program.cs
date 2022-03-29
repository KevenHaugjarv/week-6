using System;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm ennustab mis kasutajaga juhtub homme(kasutame randomit)

            string[] predictions = { "win a million", "fall in love", "buy youtube premium", "join the darkside for cookies" };
            Random rnd = new Random();
            int userNumber = rnd.Next(0, predictions.Length);
            Console.WriteLine($"today it happens that you {predictions[userNumber]}");

        }
    }
}
