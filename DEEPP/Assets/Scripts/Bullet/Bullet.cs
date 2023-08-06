using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _waitTime = 3;
    private IReturnerVector _returnerVector;
    private IMove _move;
    public void Initialize( IReturnerVector returnerVector)
    { 
        _returnerVector = returnerVector;
        SetStartMove();
        Destroy(gameObject, _waitTime);
    }
    private void SetStartMove() => _move = new RigidbodyVelocityMove(_returnerVector, _rigidbody);
    private void Update()
    {
        _move.Move();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Target>(out Target target))
        {
            target.Fall();
            Destroy(gameObject);
        }
    }
}
