using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableCamera : MonoBehaviour
{
    private IRotate _rotate;
    [SerializeField] private float _mouseSpeed = 100;
    [SerializeField] private ChanerMovementByDevice _chanerMovementByDevice;
    private void SetRotate() => _rotate = new LocalTransformRotate(transform, _chanerMovementByDevice.GetReturnerRotation());

    private void Start()
    {
        SetRotate();
    }
    private void Update()
    {
        _rotate.Rotate();
    }
}
