using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementByJoystick : IReturnerVector
{
    private readonly Joystick _joystick;
    public MovementByJoystick( Joystick joystick)
    {
        _joystick = joystick;
    }
    public Vector3 ReturnVector() => new Vector3(_joystick.Horizontal, 0, _joystick.Vertical);
}
