using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Recharger
{
    public bool IsCoolDown { get; private set; } = true;
    private readonly int _reloadTime;
    private Action _action;
    public Recharger(int reloadTime)
    {
        _reloadTime = reloadTime;
    }
    public Recharger(int reloadTime, Action action)
    {
        _reloadTime = reloadTime;
        _action = action;
    }
    public void CoolDown()
    {
        IsCoolDown = false;
        Timer timer = new Timer(Reload, null, _reloadTime, Timeout.Infinite);
    }
    private void Reload(object obj)
    {
        IsCoolDown = true;
        if (_action != null)
        {
            Debug.Log("W@! " + _action);
            _action();
        }
    }
}
