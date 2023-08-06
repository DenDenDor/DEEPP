using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAttackContainer : IAttack
{
    public IAttack IAttack { get; }
    public void Initialize(IAttack attack);
}
