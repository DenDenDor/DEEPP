using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootByBullet : IAttack
{
    private readonly float _damage;
    private readonly Bullet _bullet;
    private readonly Transform _shotPoint;
    private readonly float _bulletSpeed;
    public ShootByBullet(float damage, float bulletSpeed, Bullet bullet, Transform shotPoint)
    {
        _damage = damage;
        _bullet = bullet;
        _bulletSpeed = bulletSpeed;
        _shotPoint = shotPoint;
    }
    public void Attack()
    {
        Bullet bullet = MonoBehaviour.Instantiate(_bullet, _shotPoint.position, _shotPoint.rotation);
        bullet.Initialize(new SimpleReturnerVector(_shotPoint.forward * _bulletSpeed));
    }
}
