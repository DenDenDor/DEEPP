using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearerJoystick : ChangerJoystickState
{
    public AppearerJoystick(Joystick joystick) : base(joystick)
    {
    }

    public override void ChangeJoystickState()
    {
        _joystick.gameObject.SetActive(true);
    }
}
