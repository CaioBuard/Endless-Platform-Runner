using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
   private float moveSpeed = 7f;
   private float jumpHeight = 5f;
   public bool onPlatform = true;
   //private int notVisibleCount = 0; 



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
    void Jump()
    {
        if (Input.GetButtonDown("Jump") && onPlatform)
        {
            onPlatform = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce
            (new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
    }
    
}
