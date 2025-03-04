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
    [SerializeField] private int maxNumberOfItems = 8;
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private TextMeshProUGUI coinsText;


    [SerializeField] private int itemsNum;

    void Start()
    {
        itemsNum = 0;
        coinsText.text = coins.ToString() + "€";
    }
    public void AddItem(int price, Image itemImage, string itemName, int itemNumber, bool isBought)
    {

        if (price <= coins && itemsNum <= maxNumberOfItems)
        {
            if (isBought)
            {
                GameObject itemBought = transform.Find(itemName).gameObject;
                itemBought.GetComponentInChildren<TextMeshProUGUI>().text = "x" + itemNumber.ToString();
            }
            else
            {

                GameObject item = Instantiate(itemPrefab, Vector2.zero, Quaternion.identity, transform);
                item.name = itemName;
                item.GetComponent<Image>().sprite = itemImage.sprite;
                item.GetComponentInChildren<TextMeshProUGUI>().text = "";
                // aumentar itemsNum porque se agrega un item nuevo al inventario, en vez de una unidad de un item ya existente
                itemsNum++;

            }
            // agrandar inventario en caso que lo necesite 
            if (itemsNum >= maxNumberOfItems / 2)
            {
                //    cambia grid row a 2
                GridLayoutGroup grid = GetComponent<GridLayoutGroup>();
                grid.constraint = GridLayoutGroup.Constraint.FixedRowCount;
                grid.constraintCount = 2;
                // rescata al padre con tag inventoryContainer
                GameObject inventoryContainer = GameObject.FindGameObjectWithTag("InventoryContainer");
                // cambia el height del padre
                RectTransform inventoryContainerRectTransform = inventoryContainer.GetComponent<RectTransform>();
                inventoryContainerRectTransform.sizeDelta = new Vector2(inventoryContainerRectTransform.sizeDelta.x, 330);
                inventoryContainerRectTransform.anchoredPosition = new Vector2(inventoryContainerRectTransform.anchoredPosition.x, -170);

            }
            coins -= price;
            coinsText.text = coins.ToString() + "€";
       

        }

    }
}
