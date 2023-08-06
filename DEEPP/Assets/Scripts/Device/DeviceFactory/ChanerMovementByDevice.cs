using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChanerMovementByDevice : MonoBehaviour
{
    [SerializeField] private List<DeviceFactory> _deviceFactories = new List<DeviceFactory>();
    [SerializeField] private bool _isMobileDevice;
    private DeviceFactory _currentDeviceFactory;
   
    private void Awake()
    {
        _isMobileDevice = Loader<SavableDevice>.Load(new SavableDevice()).NameOfDevice == "MOBILE";
        _currentDeviceFactory =  _isMobileDevice  ? _deviceFactories.Find(e => e is MobileDeviceFactory) : _deviceFactories.Find(e => e is ComputerFactory);
        _currentDeviceFactory.GetChangerJoystickState().ChangeJoystickState();
    }
    public IReturnerVector GetReturnerVector() =>_currentDeviceFactory.GetReturnerVector();
    public IRotate GetRotate() => _currentDeviceFactory.GetPlayerRotate();
    public IAttackContainer GetAttack() => _currentDeviceFactory.GetAttack();
    public IReturnerRotation GetReturnerRotation() => _currentDeviceFactory.GetRotation();
}
