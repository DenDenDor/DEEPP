using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnerPlayerRotation : IReturnerVector
{
    private readonly float _speed = 100;
    public Vector3 ReturnVector()
    {
        float mouseX = Input.GetAxis("Mouse X");
       return Vector3.up* mouseX * _speed * Time.deltaTime;
        
    }
}
