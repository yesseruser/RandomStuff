using RandomStuff;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person testGuy = new Person("Doesn'tknow Hisname", new Gender(true));
            testGuy.PrintInfo();
            testGuy.TimePass(30);
            testGuy.PrintInfo();
            Consumable SuperFood = new Consumable(true, "Super Food", 100, 100, 100);
            testGuy.Consume(SuperFood, true);
            testGuy.PrintInfo();
        }
    }
}
