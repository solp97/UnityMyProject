using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove: MonoBehaviour
{
    GameObject PlayerObj;
    Rigidbody2D PlayerRigd;
    public float BouncePower = 2f;


    void Awake()
    {
        PlayerObj = GetComponent<GameObject>();
       PlayerRigd = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("�ε���");
        if (collision.gameObject.tag == "Jump")
        {
            Debug.Log("�����뿡 �ε���");
            bounce();
        }
    }

    void bounce()
    {
        PlayerRigd.AddForce(Vector2.up * BouncePower, ForceMode2D.Impulse);
    }
}
