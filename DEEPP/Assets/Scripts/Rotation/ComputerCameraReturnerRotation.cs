using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerCameraReturnerRotation : IReturnerRotation
{
    private readonly float _mouseSpeed;
    private float _xRotation;
    public ComputerCameraReturnerRotation(float speed)
    {
        _mouseSpeed = speed;
    }
    public Quaternion ReturnQuaternion()
    {
        _xRotation -= Input.GetAxis("Mouse Y") *_mouseSpeed * Time.deltaTime;
        _xRotation = Mathf.Clamp(_xRotation, -90, 90);
        return Quaternion.Euler(_xRotation,0,0);
    }
}
