using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Game
{
    public static void Main(string[] args)
    {
        // Cria o personagem com uma espada inicial
        IWeapon initialWeapon = WeaponFactory.CreateWeapon("sword");
        Character knight = new Character(initialWeapon);

        // O personagem ataca com a espada
        knight.PerformAttack();

        // Troca para uma arma de arco
        IWeapon bow = WeaponFactory.CreateWeapon("bow");
        knight.SetWeapon(bow);
        knight.PerformAttack();

        // Troca para uma varinha mágica
        IWeapon magicWand = WeaponFactory.CreateWeapon("magicwand");
        knight.SetWeapon(magicWand);
        knight.PerformAttack();
    }
}
