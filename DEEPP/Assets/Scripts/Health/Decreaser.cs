using System.Collections;
using System;
using UnityEngine;

public class Decreaser : IValueHandler
{
    private readonly float _subtrahend;
    public Decreaser(float subtrahend)
    {
        _subtrahend = subtrahend;
    }
    public float ReturnValue(float health)
    {
        if (_subtrahend.IsEqualZero() || _subtrahend.IsNegative())
        {
            throw new InvalidOperationException();
        }
        return health - _subtrahend;
    }
}
