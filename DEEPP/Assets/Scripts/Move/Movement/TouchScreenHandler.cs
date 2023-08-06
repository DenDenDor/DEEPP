using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchScreenHandler
{
    private readonly float _halfScreenWidth;
    private readonly float _cameraSensitivity;
    private readonly int _touchID = -1;
    private readonly int _size = 2;
    private int _rightFingerID = -1;

    public Vector2 LookInput { get; private set; }
    public TouchScreenHandler(float cameraSensitivity)
    {
        _cameraSensitivity = cameraSensitivity;
        _halfScreenWidth = Screen.width / _size;
    }
    public void GetTouchInput()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (touch.position.x > _halfScreenWidth && _rightFingerID == _touchID)
                    {
                        _rightFingerID = touch.fingerId;
                    }
                    break;
                case TouchPhase.Moved:
                    if (CanTouch(touch))
                    {
                        LookInput = touch.deltaPosition * _cameraSensitivity * Time.deltaTime;
                    }
                    break;
                case TouchPhase.Stationary:
                    if (CanTouch(touch))
                    {
                        LookInput = Vector2.zero;
                    }
                    break;
                case TouchPhase.Canceled:
                    if (CanTouch(touch))
                    {
                        _rightFingerID = _touchID;
                    }
                    break;
                default:
                    break;
            }
        }
    }
    private bool CanTouch(Touch touch) => touch.fingerId == _rightFingerID;
}
