namespace StrategyTest.Strategies
{
    public class Gun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with a gun");
        }
    }
}
