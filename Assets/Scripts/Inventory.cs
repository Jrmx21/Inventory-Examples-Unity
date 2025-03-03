using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{

    [SerializeField] private int coins = 50;
    [SerializeField] private int maxNumberOfItems = 4;
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private TextMeshProUGUI coinsText;

    private int itemsNum;

    void Start()
    {
        itemsNum = 0;
        coinsText.text = coins.ToString() + "€";
    }
    public void AddItem(int price, Image itemImage)
    {
        if (price <= coins && itemsNum < maxNumberOfItems)
        {

            coins -= price;
            coinsText.text = coins.ToString() + "€";
            itemsNum++;
            GameObject item = Instantiate(itemPrefab, Vector2.zero, Quaternion.identity, transform);
            item.GetComponent<Image>().sprite = itemImage.sprite;
        }
    }
}
