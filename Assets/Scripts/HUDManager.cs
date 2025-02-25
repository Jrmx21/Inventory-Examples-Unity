using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-10)]
public class HUDManager : MonoBehaviour
{
    void Awake()
    {
        GameManager.Instance.HUD = this;
    }
    [SerializeField] private TMPro.TextMeshProUGUI coinText;
    public void updateCoinText(int coins)
    {
        coinText.text = "Coins: " + coins;
    }

}
