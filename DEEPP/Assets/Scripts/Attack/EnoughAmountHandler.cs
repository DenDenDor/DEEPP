using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnoughAmountHandler : IAttack
{
    private readonly IAttack _attack;
    private readonly Amount _amount;
    private readonly int _bulletExpense = 1;
    public EnoughAmountHandler(IAttack attack, Amount amount)
    {
        _attack = attack;
        _amount = amount;
    }

    public void Attack()
    {
        if (_amount.CountOfBullet.IsNegative() == false && _amount.CountOfBullet.IsEqualZero() == false)
        {
            _attack.Attack();
            _amount.ChangeAmount(new Decreaser(_bulletExpense));
        }
    }
}
