using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileCameraRotation : IReturnerRotation
{
    private float _cameraPitch;
    private readonly TouchScreenHandler _touchScreenHandler;
    public MobileCameraRotation(TouchScreenHandler touchScreenHandler)
    {
        _touchScreenHandler = touchScreenHandler;
    }
    public Quaternion ReturnQuaternion()
    {
        _cameraPitch = Mathf.Clamp(_cameraPitch - _touchScreenHandler.LookInput.y, -90, 90);
        return Quaternion.Euler(_cameraPitch, 0, 0);
    }
}
