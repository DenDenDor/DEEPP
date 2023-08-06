using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Health 
{
    private readonly List<IHealthConditional> _healthConditionals = new List<IHealthConditional>();
    public float CurrentHealth { get; private set; }
    public float MaxHealth { get; private set; }
    public event Action OnApplyDamage;
    public event Action OnDeath;
    public Health(float currentHealth, List<IHealthConditional> healthConditionals)
    {
        CurrentHealth = currentHealth;
        MaxHealth = currentHealth;
        _healthConditionals = healthConditionals;

    }
    public void ChangeHealth(IValueHandler healthHandler)
    {
        if (_healthConditionals.All(e=> e.CanChangeHealth()))
        {
            CurrentHealth = healthHandler.ReturnValue(CurrentHealth);
            OnApplyDamage?.Invoke();
            if (CurrentHealth < 0)
            {
                OnDeath?.Invoke();
            }
        }
        
    }
}
