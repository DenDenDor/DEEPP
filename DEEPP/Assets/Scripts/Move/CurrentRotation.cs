using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentRotation : IMove, IRotate
{
    private readonly Transform _transform;
    public CurrentRotation(Transform transform)
    {
        _transform = transform;
    }
    public IReturnerVector ReturnerVector => throw new System.NotImplementedException();

    public void Move()
    {
        _transform.rotation = _transform.rotation;
    }

    public void Rotate()
    {
        _transform.rotation = _transform.rotation;
    }
}
