using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlayerRotation : IReturnerVector
{
    private readonly Transform _transform;
    private readonly TouchScreenHandler _touchScreenHandler;
    public MobilePlayerRotation(TouchScreenHandler touchScreenHandler, Transform transform)
    {
        _transform = transform;
        _touchScreenHandler = touchScreenHandler;
    }
    public Vector3 ReturnVector()
    {
        _touchScreenHandler.GetTouchInput();
        return _transform.up;
    }
}
