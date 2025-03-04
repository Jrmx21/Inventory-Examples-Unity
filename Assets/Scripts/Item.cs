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
    [SerializeField] private Animator itemAnimator;

    // Dicionario itemsInInventory
    // Key: itemName
    // Value: itemNumber
    public Dictionary<string, int> itemsInInventory = new Dictionary<string, int>();

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

        // agregar item a itemsInInventory y suma valor
        if (!itemsInInventory.ContainsKey(itemName.text))
        {
            itemsInInventory.Add(itemName.text, 1);
            inventory.AddItem(price, itemImage, itemName.text, itemsInInventory[itemName.text], false);

        }
        else
        {
            // sumale 1 al value
            itemsInInventory[itemName.text] += 1;
            inventory.AddItem(price, itemImage, itemName.text, itemsInInventory[itemName.text], true);
        }


        // compra objeto

    }

    public void onPointerEnter()
    {

        itemAnimator.Play("MouseOver");
    }

    public void onPointerExit()
    {
        itemAnimator.Play("Idle");
    }
    // TODO: rango de itemsNum
}
