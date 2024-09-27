using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public static class WeaponFactory
{
    // Método para criar a arma com base no tipo
    public static IWeapon CreateWeapon(string weaponType)
    {
        switch (weaponType.ToLower())
        {
            case "sword":
                return new Sword();
            case "bow":
                return new Bow();
            case "magicwand":
                return new MagicWand();
            default:
                throw new ArgumentException("Tipo de arma desconhecido");
        }
    }
}
