using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapHook : MonoBehaviour
{
    public LineRenderer line;
    public Transform hook;
    private HookPoint hookPoint;
    bool isHookActive;
    // Start is called before the first frame update
    void Start()
    {
        hookPoint = GetComponent<HookPoint>();
        isHookActive = false;
        line.positionCount = 2;
        line.endWidth = line.startWidth = 0.05f;
        line.SetPosition(0, transform.position);
        line.SetPosition(1, hook.position);
        line.useWorldSpace = true;
    }

    // Update is called once per frame
    void Update()
    {
        line.SetPosition(0, transform.position);
        line.SetPosition(1, hook.position);

        if(Input.GetMouseButtonDown(0))
        {
            hook.position = hookPoint.myVector2;
        }

        if(Input.GetMouseButton(0) && hookPoint.HookAble)
        {
            
            hook.gameObject.SetActive(true);
            isHookActive = true;
        }
        if(Input.GetMouseButtonUp(0))
        {
            hook.gameObject.SetActive(false);
            isHookActive = false;
        }

    }
}
