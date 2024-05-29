using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTest.Strategies
{
    public class ShutGun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("attacks with a shutgun ");
        }
    }
}
