using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranformMove : IMove
{
    private Transform _transform;
    private Transform _target;
    public IReturnerVector ReturnerVector { get; private set; }
    public TranformMove(IReturnerVector returnerVector, Transform transform, Transform target)
    {
        _target = target;
        _transform = transform;
        ReturnerVector = returnerVector;
    }
    public void Move()
    {
        _transform.position = Vector3.MoveTowards(_transform.position, _target.position, 2 * Time.deltaTime);
    }
}
