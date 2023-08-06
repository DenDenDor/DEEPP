using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleMethodRotate : IRotate
{
    private readonly Transform _transform;
    private readonly IReturnerVector _returnerVector;
    private readonly TouchScreenHandler _touchScreenHandler;
    public AngleMethodRotate(IReturnerVector returnerRotation, TouchScreenHandler touchScreenHandler, Transform transform)
    {
        _transform = transform;
        _returnerVector = returnerRotation;
        _touchScreenHandler = touchScreenHandler;
    }
    public void Rotate() => _transform.Rotate(_returnerVector.ReturnVector(),_touchScreenHandler.LookInput.x);

}
