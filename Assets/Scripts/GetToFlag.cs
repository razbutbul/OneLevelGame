using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetToFlag : MonoBehaviour
{ 
    [SerializeField] private Text GameOver;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Flag"))
        {
            GameOver.text = "GAME OVER";
        }
    }
}
