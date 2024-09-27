using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class MagicWand : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Ataque com Varinha Mágica! Cast spell!");
    }
}
