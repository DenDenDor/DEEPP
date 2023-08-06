using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllableMovement : IReturnerVector
{
    private readonly Transform _transform;
    private readonly float _speed;
    private readonly IReturnerVector _returnerVector;
    public ControllableMovement(IReturnerVector returnerVector, Transform transform, float speed)
    {
        _returnerVector = returnerVector;
        _transform = transform;
        _speed = speed;
    }
    public Vector3 ReturnVector()
    {
       return (_transform.right * _returnerVector.ReturnVector().x + _transform.forward * _returnerVector.ReturnVector().z) * _speed * Time.deltaTime;
    }

}
