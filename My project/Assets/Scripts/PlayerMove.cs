using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private bool _isHook = false;
    float currentDistance = 0f;
    float distance = 0f;
    GameObject FindNearHook()
    {
        GameObject[] hooks;
        hooks = GameObject.FindGameObjectsWithTag("Hook");
        
        distance = Mathf.Infinity;
        Vector3 myPos = transform.position;
        GameObject closest = null;
        foreach (GameObject hook in hooks)
        {
            Vector3 withHookPos = hook.transform.position - myPos;
            currentDistance = withHookPos.sqrMagnitude;
            hook.transform.GetChild(0).gameObject.SetActive(currentDistance < distance);
            if (currentDistance < distance)
            {
                closest = hook;
                distance = currentDistance;
            }
        }
        return closest;
    }

    private void Update()
    {
        GameObject closest = FindNearHook();

        if (currentDistance < distance)
        {
        closest.transform.GetChild(0).gameObject.SetActive(currentDistance < distance);
        }
        else
        {
        closest.transform.GetChild(0).gameObject.SetActive(false);
        }


        if (Input.GetMouseButtonDown(0))
        {
            _isHook = true;
        }
        if(Input.GetMouseButton(0))
        {
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
}

