using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    public int AbleHookCount = 0;
    public float ShortestDistanceToPlayer;
    public GameObject player;
    private Stage stage;
    public int StageID = 1;


    private void Awake()
    {
        stage = GetComponent<Stage>();

        string path = $"Resources/Hook{StageID}";
        GameObject stageObj = Resources.Load(path,typeof(GameObject)) as GameObject;
        stage = stageObj.GetComponent<Stage>();
    }

    public void SetStage()
    {

    }
    private void Update()
    {
        
    }
}
