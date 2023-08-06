using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private Transform _camera;
    [SerializeField] private float _cameraSensitivity;
    [SerializeField] private Joystick _joystick;
    private int _rightFingerID = -1;
    private float _halfScreenWidth;
    private Vector2 _lookInput;
    private float _cameraPitch;
    private float _moveInputDeadZone;
    private void Start()
    {
        _halfScreenWidth = Screen.width / 2;
    }
    private void FixedUpdate()
    {
        if (_rightFingerID != -1)
        {
            LookAround();
        }
    }
    private void Update()
    {
        GetTouchInput();
    }
    private void GetTouchInput()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch t = Input.GetTouch(i);
            switch (t.phase)
            {
                case TouchPhase.Began:
                    if (t.position.x > _halfScreenWidth && _rightFingerID == -1)
                    {
                        _rightFingerID = t.fingerId;
                    }
                    break;
                case TouchPhase.Moved:
                    if (t.fingerId == _rightFingerID)
                    {
                        _lookInput = t.deltaPosition * _cameraSensitivity * Time.deltaTime;
                    }
                    break;
                case TouchPhase.Stationary:
                    if (t.fingerId ==_rightFingerID)
                    {
                        _lookInput = Vector2.zero;
                    }
                    break;
                case TouchPhase.Ended:
                    break;
                case TouchPhase.Canceled:
                    if (t.fingerId == _rightFingerID)
                    {
                        _rightFingerID = -1;
                    }
                    break;
                default:
                    break;
            }
        }
    }
    private void LookAround()
    {
        _cameraPitch = Mathf.Clamp(_cameraPitch - _lookInput.y, -90, 90);
        _camera.localRotation = Quaternion.Euler(_cameraPitch, 0, 0);
        transform.Rotate(transform.up, _lookInput.x);
    }

}