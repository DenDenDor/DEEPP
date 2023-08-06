using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMove 
{
    public IReturnerVector ReturnerVector { get; }
    public void Move();
}
