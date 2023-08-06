using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleReturnerVector : IReturnerVector
{
    private Vector3 _vector;
    public SimpleReturnerVector(Vector3 vector)
    {
        _vector = vector;
    }
    public Vector3 ReturnVector() => _vector;
}
