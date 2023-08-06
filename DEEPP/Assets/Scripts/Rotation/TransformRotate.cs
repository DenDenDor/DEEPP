using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotate : IRotate
{
    private readonly Transform _transform;
    public IReturnerRotation ReturnerRotation { get; private set; }
    public TransformRotate(Transform transform, IReturnerRotation returnerRotation)
    {
        _transform = transform;
        ReturnerRotation = returnerRotation;
    }
    public void Rotate()
    {
        _transform.rotation = ReturnerRotation.ReturnQuaternion();
    }
}
