using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour, IShootSubscriber
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Weapon _weapon;
    private IFollowed _followed;
    private void Click()
    {
        _animator.SetTrigger("Shoot");
    }
    private void OnDisable()
    {
        _followed.OnFollow -= Click;
    }

    public void Subscribe(IFollowed followed)
    {
        followed.OnFollow += Click;
        _followed = followed;
    }
}
