using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour
{

    [SerializeField] private ItemManagerSO item;

    void Awake()
    {
        GetComponent<SpriteRenderer>().sprite = item.icon;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerController>().pickUpItemManager(item);
            Destroy(gameObject);
        }
    }
}
