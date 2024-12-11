using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    [SerializeField] private Player player;
    // Start is called before the first frame update
    void Start()
    {
        player.playerName = "Tùng";
        player.playerScore = 0;
        player.DisplayScore();
        player.AddScore(10);
        player.AddScore(20);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.AddScore(25);
            
        }
    }
}

[Serializable]
public class Player
{
    public string playerName;
    public int playerScore;
    public void DisplayScore()
    {
        Debug.Log($"{playerName}'s score: {playerScore}");
    }
    public void AddScore(int points)
    {
        playerScore += points;
        Debug.Log(points + " points added to " + playerName + "'s score. Total score: "
        + playerScore);
    }
}