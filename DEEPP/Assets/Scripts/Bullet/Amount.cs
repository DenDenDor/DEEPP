using System;
using System.Collections.Generic;
using UnityEngine;
[Serializable]
public class Amount : IFollowed
{
    public int CountOfBullet { get; private set; }
    public event Action OnFollow;
    public Amount(int countOfBullet)
    {
        CountOfBullet = countOfBullet;
        new SubscribeHandler(this).SubscibeAll<IAmountSubscriber>();
    }
    public void ChangeAmount(IValueHandler valueHandler)
    {
        CountOfBullet = (int) valueHandler.ReturnValue(CountOfBullet);
        OnFollow?.Invoke();
    }
}
