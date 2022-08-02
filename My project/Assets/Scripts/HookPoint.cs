using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPoint : MonoBehaviour
{
    SpriteRenderer renderer;
    Transform transform;

    public GameObject Circle;
    public Transform Player;
    public bool ShortDistance;
    public float ShortestDist;
    public float distanceWihtPlayer;
    public Vector2 myVector2;
    private Transform myPos;
    private bool HookAble;


    private void Awake()
    {
        myPos = GetComponent<Transform>();
        renderer = GetComponent<SpriteRenderer>();
        transform = GetComponent<Transform>();
        ShortestDist = 1000f;
        myVector2 = myPos.position;
    }

    private void Update()
    {
        distanceWihtPlayer = Vector2.Distance(transform.position, Player.position);
        if (ShortestDist >= distanceWihtPlayer)
        {
            ShortestDist = distanceWihtPlayer;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        /* WhoIsClosest(GetMyPos);*/
        GameManager.Instance. AbleHookCount++;

        Debug.Log("플레이어 인식");
        if(collision.gameObject.tag == "Player" /*&& ShortDistance*/)
        {
            HookAble = true;
            Debug.Log("후크사용가능");
            Circle.SetActive(true);
            renderer.color = Color.green;
           
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        ShortDistance = false;
        if (ShortDistance == false)
        {
            GameManager.Instance.AbleHookCount--;
            if (GameManager.Instance.AbleHookCount <= 0) GameManager.Instance.AbleHookCount = 0;
            Circle.SetActive(false);
            HookAble = false;
            renderer.color = Color.red;
        }
    }
}
