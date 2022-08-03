using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Transform Player;
    Vector2 StartPos;
    private void Start()
    {
         StartPos = Player.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.transform.position = StartPos;
    }
}
