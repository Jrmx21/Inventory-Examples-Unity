using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    [SerializeField] private GameObject itemPrefab;
    [SerializeField] private int maxNumberOfItems = 6;
    [SerializeField] private ItemTemplateSO[] itemTemplatesArray;
    [SerializeField] private List<ItemTemplateSO> itemsTemporalList;

    private Item item;
    void Start()
    {
        itemsTemporalList.AddRange(itemTemplatesArray);
        for (int i = 0; i < maxNumberOfItems; i++)
        {
            GameObject itemShop = Instantiate(itemPrefab, Vector2.zero, Quaternion.identity, transform);
            int index = Random.Range(0, itemsTemporalList.Count);
            item = itemShop.GetComponent<Item>();
            item.createItemFromTemplate(itemsTemporalList[index]);
            itemsTemporalList.RemoveAt(index);
        }
    }
}
