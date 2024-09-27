using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Bow : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Ataque com Arco! Arrow shot!");
    }
}
