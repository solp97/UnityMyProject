using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotate : MonoBehaviour
{
    Transform circle;

    private void Awake()
    {
        circle = GetComponent<Transform>();
    }
    // Update is called once per frame
    void Update()
    {
        circle.Rotate(0f, 0f, 0.07f);
    }
}
