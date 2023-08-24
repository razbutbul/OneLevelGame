using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   private Rigidbody2D Rbody;
  

   private void Start()
    {
        Rbody = GetComponent<Rigidbody2D>();
    }
   private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Rbody.velocity = new Vector3(Rbody.velocity.x, 5f);
        }

        float dirofX = Input.GetAxisRaw("Horizontal");
        Rbody.velocity = new Vector2(dirofX * 3f,Rbody.velocity.y);
    }
}
