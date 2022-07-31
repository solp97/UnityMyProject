using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int AbleHookCount = 0;
    public float ShortestDistanceToPlayer;
    public GameObject player;
    
    private Stage stage;


    private void Awake()
    {
        stage = GetComponent<Stage>();
    }
    private void Update()
    {
        
    }
}
