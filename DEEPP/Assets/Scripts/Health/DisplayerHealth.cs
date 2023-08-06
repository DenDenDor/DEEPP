using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DisplayerHealth : MonoBehaviour
{
    private Health _health;
    [SerializeField] private Image _bar;
    private void Start()
    {
        _health = GetComponentInParent<ICollectorHealth>().Health;
        _health.OnApplyDamage += DisplayHealth;
    }
    public void DisplayHealth()
    {
        _bar.fillAmount = _health.CurrentHealth / _health.MaxHealth;
    }
    private void OnDisable()
    {
        _health.OnApplyDamage -= DisplayHealth;
    }
}
