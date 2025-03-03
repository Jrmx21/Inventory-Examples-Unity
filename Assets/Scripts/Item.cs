using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private TextMeshProUGUI itemName;
    [SerializeField] private TextMeshProUGUI itemPrice;
    

    private int price;
    private Inventory inventory;


    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Inventory").GetComponent<Inventory>();
    }

    public void createItemFromTemplate(ItemTemplateSO itemTemplate)
    {
        itemImage.sprite = itemTemplate.itemImage;
        itemName.text = itemTemplate.itemName;
        itemPrice.text = itemTemplate.itemPrice.ToString() + "€";
        Debug.Log("Item price: " + itemTemplate.itemPrice);
        Debug.Log("item name" + itemTemplate.itemName);
        price = itemTemplate.itemPrice;
    }
    public void buyItem()
    {
        inventory.AddItem(price, itemImage, itemName.text);
    }

    public void onPointerEnter()
    {
        itemImage.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    public void onPointerExit()
    {
        itemImage.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    // TODO: resaltar on pointer, color o zoom
    // TODO: X1, X2 ,X3 NUM items
    // TODO: rango de itemsNum
}
