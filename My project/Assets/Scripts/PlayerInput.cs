using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    GameObject myObject;
    Vector2 myPosition;

    private void Awake()
    {
        myObject = GetComponent<GameObject>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            myPosition= myObject.transform.position;
        }
    }
}
