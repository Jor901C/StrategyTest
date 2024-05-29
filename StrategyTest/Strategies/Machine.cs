using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyTest.Strategies
{
    public class Machine : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Attacks with a machine");
        }
    }
}
