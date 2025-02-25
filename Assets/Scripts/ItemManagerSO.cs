using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory Item", menuName = "Inventory Item")]
public class ItemManagerSO : ScriptableObject
{

    
    [SerializeField] public string itemName;
    // minimum price is 1

    [Min(1)][SerializeField] public int itemPrice;
    [SerializeField] public string itemDescription;
    [SerializeField] public Sprite icon;



}
