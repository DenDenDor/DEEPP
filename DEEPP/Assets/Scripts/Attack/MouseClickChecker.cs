using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickChecker : IAttack, IAttackContainer
{
    public IAttack IAttack { get; private set; }

    public event Action OnFollow;

    public void Initialize(IAttack attack)
    {
        IAttack = attack;
    }
    public void Attack()
    {
        if (Input.GetMouseButtonDown(0))
        {
            IAttack.Attack();
        }
    }
}
