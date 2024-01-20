using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiGravScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.GetComponent<Rigidbody2D>())
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>(); //obtain rigidbody of other object
            rb.gravityScale = -1; //inverse grav
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.GetComponent<Rigidbody2D>())
        {
            Rigidbody2D rb = other.GetComponent<Rigidbody2D>();
            rb.gravityScale = 1; //set grav back
        }
    }
}
