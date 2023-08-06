using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SubscribeHandler
{
    private readonly IFollowed _followed;
    public SubscribeHandler(IFollowed followed)
    {
        _followed = followed;
    }
     public void SubscibeAll<T>() where T : ISubscriber
    {
        foreach (var item in MonoBehaviour.FindObjectsOfType<MonoBehaviour>().OfType<T>())
        {
            item.Subscribe(_followed);
        }  

    }
}
