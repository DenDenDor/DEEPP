using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MethodRotate : IRotate
{
    private readonly Transform _transform;
    private readonly IReturnerVector _returnerVector;
    public MethodRotate(Transform transform, IReturnerVector returnerRotation)
    {
        _transform = transform;
        _returnerVector = returnerRotation;
    }
    public void Rotate() => _transform.Rotate(_returnerVector.ReturnVector());
}
