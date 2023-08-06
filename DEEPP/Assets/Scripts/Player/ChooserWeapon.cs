using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ChooserWeapon : MonoBehaviour, IFollowed
{
    [SerializeField] private List<Weapon> _weapons;
    public Weapon PreviusWeapon { get; private set; }
    public Weapon CurrentWeapon { get; private set; }
    public event Action OnFollow;
    public void SetStartWeapon()
    {
        new SubscribeHandler(this).SubscibeAll<IWeaponSubscriber>();
        SetWeapon(_weapons.FirstOrDefault());
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            SetWeapon(_weapons.FirstOrDefault());
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            SetWeapon(_weapons.LastOrDefault());
        }
    }
    public void SetWeapon(Weapon weapon)
    {
        if (CurrentWeapon != null)
        {
            PreviusWeapon = CurrentWeapon;
            PreviusWeapon.gameObject.SetActive(false);
        }
        CurrentWeapon = weapon;
        CurrentWeapon.gameObject.SetActive(true);
        OnFollow?.Invoke();
       // FindObjectOfType<Player>().GetAttack();
    }
}
