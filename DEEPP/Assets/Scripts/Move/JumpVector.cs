using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class JumpVector : IReturnerVector
{
    private readonly IReturnerVector _returnerVector;
    private readonly Transform _checkPoint;
    private readonly float _gravity = -19.81f;
    private readonly float _raduis = 3;
    private readonly float _jumpHeight = 3;
    private readonly float _yOnGround = -2;
    private float _yVelocity;
    private bool _isGrounded;
    public JumpVector(Transform checkPoint, float jumpHeight, float raduis, IReturnerVector returnerVector)
    {
        _jumpHeight = jumpHeight;
        _raduis = raduis;
        _checkPoint = checkPoint;
        _returnerVector = returnerVector;
    }
    public Vector3 ReturnVector()
    {
        _isGrounded = Physics.OverlapSphere(_checkPoint.position, _raduis).Any(e => e.GetComponent<Ground>());
        if (_isGrounded && _yVelocity < 0)
        {
            _yVelocity = _yOnGround;
        }
        _yVelocity += _gravity * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && _isGrounded)
        {
            _yVelocity = Mathf.Sqrt(_jumpHeight * _yOnGround * _gravity);
        }
        return new Vector3(_returnerVector.ReturnVector().x, _yVelocity * Time.deltaTime, _returnerVector.ReturnVector().z);
    }

}
