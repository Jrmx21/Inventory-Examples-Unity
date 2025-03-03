using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    [SerializeField] private string[] itemsBought;

    private int itemsNum;

    void Start()
    {
        itemsNum = 0;
        coinsText.text = coins.ToString() + "€";
    }
    public void AddItem(int price, Image itemImage, string itemName)
    {
        if (price <= coins && itemsNum < maxNumberOfItems)
        {
            if (itemsBought.Contains(itemName))
            {

                return;
            }
            coins -= price;
            coinsText.text = coins.ToString() + "€";
            itemsNum++;
            GameObject item = Instantiate(itemPrefab, Vector2.zero, Quaternion.identity, transform);
            item.GetComponent<Image>().sprite = itemImage.sprite;
            item.GetComponentInChildren<TextMeshProUGUI>().text = itemName;
            itemsBought.Append(itemName);
        }
    }
}
