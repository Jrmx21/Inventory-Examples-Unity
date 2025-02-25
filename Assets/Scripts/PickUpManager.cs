using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            //  V1 recoge monedas
            // GameManager.Instance.Player.pickUpItem(coinValue);
            // V2 recoge objetos
            GameManager.Instance.Player.pickUpGameObjectItem(gameObject);
            ItemManager itemManager = gameObject.GetComponent<ItemManager>();
            Debug.Log("Picking up " + itemManager.ItemName);
            Destroy(gameObject);
        }
    }
}
