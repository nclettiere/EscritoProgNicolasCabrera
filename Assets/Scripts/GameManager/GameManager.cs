using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public GameObject player;
    public InputManager InputManager;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;

        InputManager = new InputManager();
        InputManager.Init();

        SpawnPlayer();

        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    internal PlayerController GetPlayerController()
    {
        return player.GetComponent<PlayerController>();
    }

    public void SpawnPlayer()
    {
        player = Instantiate(player, Vector3.zero, Quaternion.Euler(0, 0, 0));
    }
}
