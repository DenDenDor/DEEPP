using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetterHealth : MonoBehaviour
{
    [SerializeField] private float _startHealth;
    [SerializeField] private int _time = 5000;
    public Health GetHealth() => new Health(_startHealth, new List<IHealthConditional>() {new CoolDownHealth(_time)} );
}
