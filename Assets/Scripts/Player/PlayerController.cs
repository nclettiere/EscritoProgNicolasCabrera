using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private PlayerMovement PlayerMovement;

    public void DoJump()
    {
        PlayerMovement.Jump();
    }
    public void DoMove(float direction)
    {
        PlayerMovement.Move(direction);
    }
}
