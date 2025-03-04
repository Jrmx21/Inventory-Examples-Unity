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


    private int itemsNum;

    void Start()
    {
        itemsNum = 0;
        coinsText.text = coins.ToString() + "€";
    }
    public void AddItem(int price, Image itemImage, string itemName, int itemNumber, bool isBought)
    {

        if (price <= coins && itemsNum < maxNumberOfItems)
        {
            if (isBought)
            {
                GameObject itemBought = transform.Find(itemName).gameObject;
                itemBought.GetComponentInChildren<TextMeshProUGUI>().text = "x" + itemNumber.ToString();
                Debug.Log("Item number: " + itemNumber);

            }
            else
            {

                GameObject item = Instantiate(itemPrefab, Vector2.zero, Quaternion.identity, transform);
                item.name = itemName;
                item.GetComponent<Image>().sprite = itemImage.sprite;
                item.GetComponentInChildren<TextMeshProUGUI>().text = "x" + itemNumber.ToString();
                itemsNum++;
            }

            coins -= price;
            coinsText.text = coins.ToString() + "€";
        }

    }
}
