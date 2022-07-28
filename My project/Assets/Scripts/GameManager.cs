using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int AbleHookCount = 0;
    public GameObject player;
    private HookPoint hookpoint;

    private float[] dist;
    private float ShortDist=0f;
    private Vector2[] HookPointPositions;

    private void Update()
    {
        
    }

    public void WhoIsClosest(Vector2 HookPos)
    {
        if (AbleHookCount >= 2) //2개 이상이면 비교시작
        {
            for(int i = 0; i < AbleHookCount; i++)
            {
                HookPointPositions[i] = HookPos;
                Debug.Log($"{i}번째 포지션 할당");
                dist[i] = Vector2.Distance(player.transform.position, HookPointPositions[i]);
                ShortDist = dist[i];
                if (dist[i] <= ShortDist)
                {
                    ShortDist = dist[i];
                    hookpoint.ShortDistance = true;
                    Debug.Log("짧은거리 찾음");
                }
                else hookpoint.ShortDistance = false;
            }
        }
        else hookpoint.ShortDistance = true;
    }

}
