using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterPlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _height;
    [SerializeField] private float _radius;
    [SerializeField] private CharacterController _characterContoller;
    [SerializeField] private Transform _checkPoint;
    [SerializeField] private ChanerMovementByDevice _chanerMovementByDevice;
    public IMove GetMove() => new CharacterControllerMove(new JumpVector(_checkPoint, _height,_radius, new ControllableMovement(_chanerMovementByDevice.GetReturnerVector(), transform, _speed)), _characterContoller);
}
