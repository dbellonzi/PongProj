using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour
{
    public scoreboard sb;

    void OnCollisionEnter(Collision collision)
    {
        bool right = false;
        bool game = true;
        if(this.name=="P1_Wall")
        {
            if(sb.UpdateScore(1)) game = false;
        }
        if(this.name=="P2_Wall")
        {
            right = true;
            if(sb.UpdateScore(2)) game = false;
        } 
        // if(game) 
        collision.collider.gameObject.GetComponent<ball>().ResetBall(right);
        // else
        // {
        //     collision.collider.gameObject.GetComponent<ball>().StopBall();
        // }
    }

    // Start is called before the first frame update
    void Start()
    {
        sb = GameObject.Find("Scoreboard").GetComponent<scoreboard>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
