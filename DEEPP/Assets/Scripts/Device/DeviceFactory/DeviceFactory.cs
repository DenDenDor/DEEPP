using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DeviceFactory : MonoBehaviour
{
    [SerializeField] private protected Player _player;
    [SerializeField] private protected Joystick _joystick;
    public abstract IReturnerVector GetReturnerVector();
    public abstract IRotate GetPlayerRotate();
    public abstract IReturnerRotation GetRotation();
    public abstract IAttackContainer GetAttack();
    public abstract ChangerJoystickState GetChangerJoystickState();

}
