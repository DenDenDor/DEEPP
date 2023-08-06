using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ChangerJoystickState
{
    private protected Joystick _joystick;
    public ChangerJoystickState(Joystick joystick)
    {
        _joystick = joystick;
    }
    public abstract void ChangeJoystickState();
}
