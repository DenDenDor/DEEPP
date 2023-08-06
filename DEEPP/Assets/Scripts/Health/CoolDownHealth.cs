using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolDownHealth : IHealthConditional
{
    private readonly Recharger _recharger;
    public CoolDownHealth(int reloadTime)
    {
        _recharger = new Recharger(reloadTime);
    }
    public bool CanChangeHealth()
    {
        if (_recharger.IsCoolDown)
        {
            _recharger.CoolDown();
            return true;
        }
        return false;
    }
}
