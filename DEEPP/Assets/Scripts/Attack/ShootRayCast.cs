using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRayCast : IAttack
{
    private readonly Camera _camera;
    private readonly float _range;
    private readonly Transform _shootPoint;
    private readonly float _damage;
    public ShootRayCast(Camera camera, float range, float damage, Transform shotPoint)
    {
        _shootPoint = shotPoint;
        _damage = damage;
        _camera = camera;
        _range = range;
    }


    public void Attack()
    {
        RaycastHit raycastHit;
        if (Physics.Raycast(_shootPoint.transform.position, _camera.transform.forward, out raycastHit, _range))
        {
            if (raycastHit.collider.TryGetComponent<Target>(out Target target))
            {
                target.Fall();
            }
        }

    }
}
