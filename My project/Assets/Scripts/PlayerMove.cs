using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool _isHook;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _isHook = true;
        }
        if(Input.GetMouseButton(0))
        {
           GameObject closest = FindNearHook();

            if(_isHook)
            {
                closest.GetComponentInChildren<HingeJoint2D>().connectedBody = gameObject.GetComponentInChildren<Rigidbody2D>();
                _isHook =false; 

            }
        }
        if(Input.GetMouseButtonUp(0))
        {
            GameObject[] hooks;
            hooks = GameObject.FindGameObjectsWithTag("Hook");

            foreach(GameObject hook in hooks)
            {

                hook.GetComponentInChildren<HingeJoint2D>().connectedBody = null;
            }
            
        }
    }

     GameObject FindNearHook()
    {
        GameObject[] hooks;
        hooks = GameObject.FindGameObjectsWithTag("Hook");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 myPos = transform.position;

        foreach(GameObject hook in hooks)
        {
            Vector3 withHookPos = hook.transform.position - myPos;
            float currentDistance = withHookPos.sqrMagnitude;
            if(currentDistance < distance)
            {
                closest = hook;
                distance = currentDistance;
            }
        }
            return closest;   
    }
}

