using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField] private string itemName;
    // minimum price is 1
    [Min(1)][SerializeField] private int itemPrice;
    [SerializeField] private string itemDescription;
    [SerializeField] private Sprite icon;


    // getter and setters 
    public string ItemName { get => itemName; set => itemName = value; }
    public int ItemPrice { get => itemPrice; set => itemPrice = value; }
    public Sprite Icon { get => icon; set => icon = value; }
    public string ItemDescription { get => itemDescription; set => itemDescription = value; }


}
