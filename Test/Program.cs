using RandomStuff;
using System;

namespace Test
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person testGuy = new("Doesn'tknow Hisname", new Gender(true));
            testGuy.PrintInfo();
            testGuy.TimePass(30);
            testGuy.PrintInfo();
            Consumable SuperFood = new(true, "Super Food", 100, 100, 100);
            testGuy.Consume(SuperFood, true);
            testGuy.PrintInfo();
            Console.ReadKey();
        }
    }
}
