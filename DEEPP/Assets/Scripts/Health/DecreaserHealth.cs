using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecreaserHealth : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private float _damage = 1;
    public void DecreaseHealth()
    {
        _player.Health.ChangeHealth(new Decreaser(_damage));
    }
}
