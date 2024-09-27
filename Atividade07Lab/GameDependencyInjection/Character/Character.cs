using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class Character
{
    private IWeapon _weapon;

    // Injeção de dependência via construtor
    public Character(IWeapon weapon)
    {
        _weapon = weapon;
    }

    // Método para realizar o ataque
    public void PerformAttack()
    {
        _weapon.Attack();
    }

    // Método para mudar a arma em tempo de execução
    public void SetWeapon(IWeapon newWeapon)
    {
        _weapon = newWeapon;
    }
}
