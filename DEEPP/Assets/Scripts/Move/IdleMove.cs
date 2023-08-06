using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleMove : IMove
{
    private readonly Transform _transform;
    public IdleMove(Transform transform)
    {
        _transform = transform;
    }

    public IReturnerVector ReturnerVector => throw new System.NotImplementedException();

    public void Move()
    {
        _transform.position = _transform.position;
    }
}
