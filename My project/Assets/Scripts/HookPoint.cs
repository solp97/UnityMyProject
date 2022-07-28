using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookPoint : MonoBehaviour
{
    SpriteRenderer renderer;
    Transform transform;
    Vector2 GetMyPos;

    public GameObject Circle;
    private bool IsShort = false;
    public bool ShortDistance;
    public bool HookAble = false;

    private void Awake()
    {
        renderer = GetComponent<SpriteRenderer>();
        transform = GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.Instance.WhoIsClosest(GetMyPos);

        Debug.Log("플레이어 인식");
        if(collision.gameObject.tag == "Player" && ShortDistance)
        {
            HookAble = true;
            Debug.Log("후크사용가능");
            GetMyPos = transform.position;
            GameManager.Instance.AbleHookCount++;
            Circle.SetActive(true);
            renderer.color = Color.green;
            

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        IsShort = false;
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
