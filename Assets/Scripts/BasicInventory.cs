using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class BasicInventory : MonoBehaviour
{
    private List<ItemManagerSO> items;
    [SerializeField] private int inventorySlots = 4;
    [SerializeField] private Transform itemContainer;
    void Start()
    {
        items = new List<ItemManagerSO>();
    }

    public void addItem(ItemManagerSO item)
    {
        if (itemContainer.childCount >= inventorySlots)
        {
            Debug.Log("Inventory is full");
            return;
        }
        items.Add(item);
        GameManager.Instance.HUD.addItem(item.icon);
        Debug.Log("Adding item to inventory");

    }
}
