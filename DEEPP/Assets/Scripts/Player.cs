using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour, ICollectorHealth
{
    private IMove _move;
    private IRotate _rotate;
    private IAttack _attack;
    [SerializeField] private GetterPlayerMove _getterPlayerMove;
    [SerializeField] private GetterPlayerAttack _getterPlayerAttack;
    [SerializeField] private GetterHealth _getterHealth;
    [SerializeField] private GetterPlayerRotation _getterPlayerRotation;
    public Health Health { get; private set; }
    public TypeOfEntity TypeOfEntity { get; private set; } = TypeOfEntity.Player;
    private void Awake()
    {
        SetStartSettings();
    }
    private void Update()
    {
        Move();
        Rotate();
        Attack();
    }
    private void Move() => _move.Move();
    private void Rotate() => _rotate.Rotate();
    public void Attack() => _attack.Attack();
    private void SetStartSettings()
    {
        _rotate = _getterPlayerRotation.GetRotate();
        _move = _getterPlayerMove.GetMove();
        _attack = _getterPlayerAttack.GetAttack();
        Health = _getterHealth.GetHealth();
    }
}
