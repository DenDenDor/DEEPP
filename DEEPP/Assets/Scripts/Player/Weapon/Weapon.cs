using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public abstract IAttackContainer AdditionalAttack { get; set; }
    public Amount Amount { get; protected set; }
    public abstract IAttack GetAttack();
}
