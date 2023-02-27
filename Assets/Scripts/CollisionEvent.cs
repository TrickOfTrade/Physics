using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    private Rigidbody2D rb;
    private void Awake(){
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        rb.AddForce(Vector2.up * 100, ForceMode2D.Impulse);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Enter");
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log("Stay");
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exit");
    }
}
