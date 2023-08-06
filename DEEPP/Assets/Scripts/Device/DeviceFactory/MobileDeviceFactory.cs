using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileDeviceFactory : DeviceFactory
{
    [SerializeField] private Button _button;
    [SerializeField] private float _sensitivity;
    public TouchScreenHandler TouchScreenHandler { get; private set; }
    public override ChangerJoystickState GetChangerJoystickState()
    {
        return new AppearerJoystick(_joystick);
    }

    public override IRotate GetPlayerRotate()
    {
        TryCreateTouch();
        return new AngleMethodRotate(new MobilePlayerRotation(TouchScreenHandler, _player.transform), TouchScreenHandler, _player.transform);
    }

    public override IReturnerVector GetReturnerVector()
    {
        return new MovementByJoystick(_joystick);
    }
    private void TryCreateTouch()
    {
        if (TouchScreenHandler == null)
        {
            TouchScreenHandler = new TouchScreenHandler(_sensitivity);
        }
    }
    public override IReturnerRotation GetRotation()
    {
        TryCreateTouch();
        return new MobileCameraRotation(TouchScreenHandler);
    }

    public override IAttackContainer GetAttack() => new ButtonClick(_button);
}
