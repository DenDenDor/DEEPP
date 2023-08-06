using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    [SerializeField] private int _countOfBullets = 5;
    [SerializeField] private int _createTime = 300;
    [SerializeField] private float _damage;
    [SerializeField] private float _range;
    [SerializeField] private Transform _shotPoint;
    [SerializeField] private ChanerMovementByDevice _chanerMovementByDevice;
    public override IAttackContainer AdditionalAttack { get; set; }

    private void Awake()
    {
        Amount = new Amount(_countOfBullets);
    }
    
    public override IAttack GetAttack()
    {
        if (AdditionalAttack == null)
        {
            AdditionalAttack = _chanerMovementByDevice.GetAttack();
        }
        AdditionalAttack.Initialize(
           new CoolDownAttack(
              new EnoughAmountHandler( new SuccesfulAttack(new ShootRayCast(Camera.main, _range, _damage, _shotPoint)), Amount), _createTime));
        return AdditionalAttack;
    }


}
