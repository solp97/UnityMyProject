using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    bool isPlayerGoal = false;
    public Animation camera;
    private void Update()
    {
        if(isPlayerGoal)
        {
            camera.Play();
            Time.timeScale = 0.05f;
            Time.fixedDeltaTime = 0.0000002f * Time.timeScale;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" /*&& ShortDistance*/)
        {
            Debug.Log("ÇÃ·¹ÀÌ¾î°ñ");
            isPlayerGoal = true;

        }
    }
}

