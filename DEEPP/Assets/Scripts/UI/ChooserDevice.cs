using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChooserDevice : MonoBehaviour
{
    [SerializeField] private LoaderScene _loaderScene;
    private readonly int _numberOfScene = 1;
     public void Save(string name)
    {
        Saver<SavableDevice>.Save(new SavableDevice(name));
        _loaderScene.LoadScene(_numberOfScene);
    }
}
