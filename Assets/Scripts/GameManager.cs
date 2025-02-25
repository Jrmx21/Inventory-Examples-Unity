using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-100)]
public class GameManager : MonoBehaviour
{
    // Singleton pattern
    public static GameManager Instance { get; private set; }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // player reference
    private PlayerController player;
    public PlayerController Player { get => player; set => player = value; }
    // HUD reference
    private HUDManager hud;
    public HUDManager HUD { get => hud; set => hud = value; }



}
