using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class BasicInventory : MonoBehaviour
{
    [SerializeField] private int inventorySlots = 4;
    [SerializeField] private Transform itemContainer;
    [SerializeField] private GameObject itemPrefab;
    public void AddItem(Image image)
    {
        if (itemContainer.childCount >= inventorySlots)
        {
            Debug.Log("Inventory is full");
            return;
        }
        Debug.Log("Adding item to inventory");
        GameObject item = Instantiate(itemPrefab, itemContainer);

        item.GetComponent<Image>().sprite = image.sprite;
    }
}
