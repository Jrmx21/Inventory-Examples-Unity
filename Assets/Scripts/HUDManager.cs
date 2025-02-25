using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[DefaultExecutionOrder(-10)]
public class HUDManager : MonoBehaviour
{
    [SerializeField] private Transform itemContainer;
    [SerializeField] private GameObject itemPrefab;
    void Awake()
    {
        GameManager.Instance.HUD = this;
    }
    [SerializeField] private TMPro.TextMeshProUGUI coinText;
    public void updateCoinText(int coins)
    {
        coinText.text = "Coins: " + coins;
    }
    public void addItem(Sprite sprite)
    {
        GameObject item = Instantiate(itemPrefab, itemContainer);
        item.GetComponent<Image>().sprite = sprite;
    }
}
