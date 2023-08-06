using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayerAmount : MonoBehaviour, IAmountSubscriber
{
    [SerializeField] private Weapon _weapon;
    [SerializeField] private TextMeshProUGUI _text; 
    private IFollowed _followed;
    private void Awake()
    {
        ChangeText();
    }
    public void Subscribe(IFollowed followed)
    {
        followed.OnFollow += ChangeText;
        _followed = followed;
    }
    private void ChangeText() => _text.text = $"{_weapon.Amount.CountOfBullet}";
    private void OnDisable()
    {
        _followed.OnFollow -= ChangeText;
    }
}
