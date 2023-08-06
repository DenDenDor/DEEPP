using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonClick : IAttackContainer
{
    private bool _isClicked;
    private readonly Button _button;
    public IAttack IAttack { get; private set; }
    public ButtonClick(Button button)
    {
        _button = button;
        _button.onClick.AddListener(Click);
    }
    private void Click()
    {
        _isClicked = true;
    }
    public void Attack()
    {
        if (_isClicked)
        {
            IAttack.Attack();
            _isClicked = false;
        }
    }

    public void Initialize(IAttack attack)
    {
        IAttack = attack;
    }
}
