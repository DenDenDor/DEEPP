using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuccesfulAttack : IAttack, IFollowed
{
    private IAttack _attack;
    public event Action OnFollow;
    public SuccesfulAttack(IAttack attack)
    {
        _attack = attack;
        new SubscribeHandler(this).SubscibeAll<IShootSubscriber>();
    }

    public void Attack()
    {
        OnFollow?.Invoke();
        _attack.Attack();
    }
}
