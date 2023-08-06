using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyVelocityMove : IMove
{
    public IReturnerVector ReturnerVector { get; private set; }
    private readonly Rigidbody _rigidbody;
    public RigidbodyVelocityMove(IReturnerVector returnerVector, Rigidbody rigidbody)
    {
        ReturnerVector = returnerVector;
        _rigidbody = rigidbody;
    }
    public void Move()
    {
        _rigidbody.velocity = ReturnerVector.ReturnVector();
    }
}
