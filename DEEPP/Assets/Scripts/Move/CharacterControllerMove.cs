using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerMove : IMove
{
    public IReturnerVector ReturnerVector { get; private set; }
    private readonly CharacterController _characterController;
    public CharacterControllerMove(IReturnerVector returnerVector, CharacterController characterController)
    {
        ReturnerVector = returnerVector;
        _characterController = characterController;
    }
    public void Move()
    {
        _characterController.Move(ReturnerVector.ReturnVector());
    }
}
