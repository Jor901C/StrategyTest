using StrategyTest.Strategies;
namespace StrategyTest

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new("Stalker");
            hero.Attack();
            hero.SetWaepon(new Gun());
            hero.Attack();

        }
    }
}
