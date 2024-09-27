using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Sword : IWeapon
{
    public void Attack()
    {
        Console.WriteLine("Ataque com Espada! Slash!");
    }
}
