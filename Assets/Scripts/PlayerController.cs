using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    [SerializeField] private int coins = 0;
    [SerializeField] private BasicInventory basicInventory;
    private float horizontal;
    private float vertical;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameManager.Instance.Player = this;
        if (basicInventory == null)
        {
            Debug.LogError("Basic Inventory not set on PlayerController");
        }
        else
        {
            basicInventory = gameObject.GetComponent<BasicInventory>();
        }
    }

    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        Vector2 direction = new Vector2(horizontal, vertical);
        rb.velocity = direction * speed;
    }
    public void pickUpItem(int coinValue)
    {
        coins += coinValue;
        GameManager.Instance.HUD.updateCoinText(coins);
    }
    public void pickUpGameObjectItem(GameObject item)
    {
        // nosense code
        Sprite sprite = item.GetComponent<SpriteRenderer>().sprite;
        Image imgItem = new GameObject().AddComponent<Image>();
        imgItem.sprite = sprite;
        basicInventory.AddItem(imgItem);
    }
}
