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
        itemPrice.text = price.ToString() + "€";
        price = itemTemplate.itemPrice;
    }
    public void buyItem(){
        inventory.AddItem(price, itemImage);
    }
}
