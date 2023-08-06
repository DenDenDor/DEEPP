using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownAttack : IAttack
{
    private readonly IAttack _attack;
    private readonly Recharger _recharger;
    public CoolDownAttack(IAttack attack, int coolDown)
    {
        _attack = attack;
        _recharger = new Recharger(coolDown);
    }
    public void Attack()
    {
        if (_recharger.IsCoolDown)
        {
            _attack.Attack();
            _recharger.CoolDown();
        }
    }
}
