using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterPlayerAttack : MonoBehaviour
{

    [SerializeField] private Weapon _weapon;
    public IAttack GetAttack() => _weapon.GetAttack();
    
}
