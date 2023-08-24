using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{

    private void OnTriggerEnter2D (Collider2D item)
    {
        if (item.gameObject.CompareTag("Coins"))
        {
            Destroy(item.gameObject);
        }
    }
}
