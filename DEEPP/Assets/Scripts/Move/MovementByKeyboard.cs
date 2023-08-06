using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementByKeyboard : IReturnerVector
{
    public Vector3 ReturnVector() => new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
}
