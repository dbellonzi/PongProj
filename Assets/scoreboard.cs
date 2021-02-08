using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreboard : MonoBehaviour
{

    public Text scoreText;
    public int p1Score = 0;
    public int p2Score = 0;
    public string score;

    // private scoreboard sb;

    // // Start is called before the first frame update
    // void Start()
    // {
    //     sb = GameObject.Find("Scoreboard").GetComponent<scoreboard>();
    //     score = $"{p1Score}    {p2Score}";
    //     scoreText.text = score;
    // }

    // // Update is called once per frame
    // void Update()
    // {

    // }

    public bool UpdateScore(int player){
        if(player == 1){
            p1Score++;
        } else {
            p2Score++;
        }
        if(p1Score == 11) score = "Game Over - Player 1 Wins";
        else if(p2Score == 11) score = "Game Over - Player 2 Wins";
        else {
            score = $"P1:{p1Score} -  P2:{p2Score}";
        }
        Debug.Log(score);
        if(p1Score > 11 || p2Score > 11) 
        {
            p1Score = 0;
            p2Score = 0;
            return true;
        
        }
        else return false;
    }
}
