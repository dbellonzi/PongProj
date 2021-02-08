using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    // public float moveSpeed = 0.2f;
    private paddle p1;
    private paddle p2;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Player";
        // p1 = GameObject.Find("P1_Paddle").GetComponent<paddle>();
        // p2 = GameObject.Find("P2_Paddle").GetComponent<paddle>();
    }

    // public void MovePaddle(Paddle paddle, Vector3 dir){
    //     // paddle.transform.Translate(dir, moveSpeed);
    // }
}
