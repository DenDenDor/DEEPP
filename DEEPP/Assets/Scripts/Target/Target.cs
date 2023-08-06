using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private float _waitTime = 4;
    public void Fall()
    {
        ChangeStateOfAnimator(true);
        StartCoroutine(CoolDown());
    }
    private IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(_waitTime);
        StartAnimation();
    }

    private void ChangeStateOfAnimator(bool isTrigger) => _animator.SetBool("isFallen", isTrigger);
    public void StartAnimation() => ChangeStateOfAnimator(false);
}
