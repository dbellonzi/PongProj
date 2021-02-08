using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public float BASEVEL = 100;
    public float MAXVEL = 400;
    public float vel;
    private Rigidbody rb;
    private Vector3 dir;

    void OnCollisionEnter(Collision collision)
    {
        if(vel < MAXVEL && collision.gameObject.tag == "Player") vel *= 1.1f;
        dir = vel*collision.contacts[0].normal;
        rb.AddForce(dir);
        if(-100 < rb.velocity.z && rb.velocity.z < 0){
            rb.AddForce(new Vector3(0,0, -vel/2));
        } else if(0 < rb.velocity.z && rb.velocity.z < 100){
            rb.AddForce(new Vector3(0,0,vel/2));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // StartMovement(true); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StopBall()
    {
        transform.position = new Vector3(0,0,0);
        rb.velocity = new Vector3(0,0,0); 
    }

    public void ResetBall(bool right)
    {
        transform.position = new Vector3(1,7,0);
        rb.velocity = Vector3.zero;
        StartMovement(right);
    }

    void StartMovement(bool right)
    {
        vel = BASEVEL;
        if(right) dir = new Vector3(0,vel,vel);
        else dir = new Vector3(0,vel,-vel);
        rb.AddForce(dir);
    }
}
