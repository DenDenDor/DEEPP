using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalTransformRotate : IRotate
{
    private readonly Transform _transform;
    public IReturnerRotation ReturnerRotation { get; private set; }
    public LocalTransformRotate(Transform transform, IReturnerRotation returnerRotation)
    {
        _transform = transform;
        ReturnerRotation = returnerRotation;
    }
    public void Rotate()
    {
        _transform.localRotation = ReturnerRotation.ReturnQuaternion();
    }
}
