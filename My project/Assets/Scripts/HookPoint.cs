using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPoint : MonoBehaviour
{
    SpriteRenderer renderer;
    Transform transform;
    Vector2 GetMyPos;

    public GameObject Circle;
    public bool ShortDistance = false;
    public bool HookAble = false;

    private float distanceWihtPlayer;


    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        transform = GetComponent<Transform>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        /* WhoIsClosest(GetMyPos);*/
        GameManager.Instance. AbleHookCount++;

        Debug.Log("플레이어 인식");
        if(collision.gameObject.tag == "Player")
        {
            HookAble = true;
            Debug.Log("후크사용가능");
            GetMyPos = transform.position;
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
