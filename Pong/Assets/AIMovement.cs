using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMovement : MonoBehaviour
{
    public Transform ball;
    public float speed = 10f;
    

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if(ball.position.y > transform.position.y)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if(ball.position.y < transform.position.y)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
