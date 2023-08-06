using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterPlayerRotation : MonoBehaviour
{
    [SerializeField] private ChanerMovementByDevice _chanerMovementByDevice;
    public IRotate GetRotate() => _chanerMovementByDevice.GetRotate();
}
