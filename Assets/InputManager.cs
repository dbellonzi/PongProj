using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float moveSpeed = 0.1f;
    public paddle p1;
    public paddle p2;

    void Start(){
        p1 = GameObject.Find("P1_Paddle").GetComponent<paddle>();
        p2 = GameObject.Find("P2_Paddle").GetComponent<paddle>();
    }
    
    void Update()
    {
        if(Input.GetAxis("Paddle2") > 0 && p2.transform.position.y < 6.5){
            p2.transform.Translate(Vector3.up * Input.GetAxis("Paddle2") * moveSpeed, Space.World);
            // paddle.MovePaddle(p2, Vector3.up);
        }
        if(Input.GetAxis("Paddle2") < 0 && p2.transform.position.y > -6.5){
            p2.transform.Translate(Vector3.up * Input.GetAxis("Paddle2") * moveSpeed, Space.World);
            //paddle.MovePaddle(p2, Vector3.down);
        }
        if(Input.GetAxis("Paddle1") > 0 && p1.transform.position.y < 6.5){
            p1.transform.Translate(Vector3.up * Input.GetAxis("Paddle1") * moveSpeed, Space.World);
            //paddle.MovePaddle(p1, Vector3.up);
        }
        if(Input.GetAxis("Paddle1") < 0 && p1.transform.position.y > -6.5){
            p1.transform.Translate(Vector3.up * Input.GetAxis("Paddle1") * moveSpeed, Space.World);
            //paddle.MovePaddle(p1, Vector3.down);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            GameObject.Find("Game_Ball").GetComponent<ball>().ResetBall(true);
        }
    }

}
