using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEvent : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        rb.AddForce(Vector2.up * 100, ForceMode2D.Impulse);
    }
    
    void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Enter");
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        Debug.Log("Stay");
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        Debug.Log("Exit");
    }
}
