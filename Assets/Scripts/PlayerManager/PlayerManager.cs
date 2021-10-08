using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerController player;

    public static PlayerManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        player = GameManager.Instance.GetPlayerController();
    }

    public void MoveH(float direction)
    {
        player.DoMove(direction);
    }

    public void Jump()
    {
        player.DoJump();
    }
}
