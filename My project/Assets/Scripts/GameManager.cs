using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : Singleton<GameManager>
{
    public float ShortestDistanceToPlayer;
    public Transform player;
    public Transform Goal;
    public TextMeshProUGUI RemainDist;
    public GameObject GameOverUI;
    public Animator camera;
    
    public int StageID = 1;
    
    private Stage stage;
    private float getDistanceGoalWithPlayer;
    private void start()
    {
        
        stage = GetComponent<Stage>();
        GameOverUI.SetActive(false);
        string path = $"Resources/Hook{StageID}";
        GameObject stageObj = Resources.Load(path,typeof(GameObject)) as GameObject;
        stage = stageObj.GetComponent<Stage>();
        RemainDist = GetComponent<TextMeshProUGUI>();
    }

    public void restart()
    {
        camera.Play("Reset");
        GameOverUI.SetActive(false);
        player.position = new Vector3(-22, 3);
        Time.timeScale = 1f;
    }
    public void nextStage()
    {

    }
    private void Update()
    {
        getDistanceGoalWithPlayer = Vector2.Distance(player.position, Goal.position);
        RemainDist.text = $"Remaining Distance : {getDistanceGoalWithPlayer}M";
        
    }
}
