using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICollectorHealth
{
    public TypeOfEntity TypeOfEntity { get; }
    public Health Health{get;}
}
