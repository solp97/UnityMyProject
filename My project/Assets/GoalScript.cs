using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    bool isPlayerGoal = false;
    [SerializeField] Animator camAnim;
    public GameObject go;
    private void ShowVirtualCamera()
    {
        Time.timeScale = 0.05f;
    }


    private void Update()
    {
        if(isPlayerGoal)
        {
            Time.fixedDeltaTime = 0.0000002f * Time.timeScale;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        go.SetActive(true);

        if (collision.gameObject.tag == "Player" /*&& ShortDistance*/)
        {
            Debug.Log("ÇÃ·¹ÀÌ¾î°ñ");
            isPlayerGoal = true;

            camAnim.enabled = true;
            camAnim.Rebind();
            camAnim.Play("CamMoveAnim");

            ShowVirtualCamera();
        }
    }
}

