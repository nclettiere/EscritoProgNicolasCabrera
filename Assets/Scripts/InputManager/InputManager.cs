using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public static GameInput Input;

    public void Init()
    {
        Input = new GameInput();
        Input.Enable();

        Input.GamePlay.MoveH.performed += ctx => {
            Debug.Log("sadsad");
            GameManager.Instance.GetPlayerController().DoMove(ctx.ReadValue<float>());
        };

        Input.GamePlay.MoveH.canceled += ctx => {
            GameManager.Instance.GetPlayerController().DoMove(0);
        };

        Input.GamePlay.Jump.performed += ctx => {
            PlayerManager.Instance.Jump();
        };
    }
}
