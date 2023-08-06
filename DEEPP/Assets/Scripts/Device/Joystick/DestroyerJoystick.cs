using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerJoystick : ChangerJoystickState
{
    public DestroyerJoystick(Joystick joystick) : base(joystick)
    {
    }

    public override void ChangeJoystickState()
    {
        Object.Destroy(_joystick.gameObject);
    }
}
