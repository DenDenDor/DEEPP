using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavableDevice : ISavable
{
   public string NameOfDevice;
   public SavableDevice(string nameOfDevice)
   {
    NameOfDevice = nameOfDevice;
   }
   public SavableDevice()
   {
    
   }
}
