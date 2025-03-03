using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemTemplate", menuName = "Shop item template")]
public class ItemTemplateSO : ScriptableObject
{

    public Sprite itemImage;
    public string itemName;
    public int itemPrice;
}
