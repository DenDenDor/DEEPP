using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerFactory : DeviceFactory
{
    [SerializeField] private float _mouseSpeed;
    public override ChangerJoystickState GetChangerJoystickState() => new DestroyerJoystick(_joystick);
    public override IRotate GetPlayerRotate() => new MethodRotate(_player.transform, new ReturnerPlayerRotation());

    public override IReturnerRotation GetRotation() => new ComputerCameraReturnerRotation(_mouseSpeed);
    public override IReturnerVector GetReturnerVector() => new MovementByKeyboard();

    public override IAttackContainer GetAttack() => new MouseClickChecker();
}
