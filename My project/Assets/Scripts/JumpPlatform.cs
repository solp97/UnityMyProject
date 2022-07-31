using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    public Rigidbody2D PlayerRigd;
    public float BouncePower = 2f;


    public void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("ºÎµúÈû");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Á¡ÇÁ´ë¿¡ ºÎµúÈû");
            bounce();
        }
    }

    void bounce()
    {
        PlayerRigd.AddForce(Vector2.up * BouncePower, ForceMode2D.Impulse);
    }
}

