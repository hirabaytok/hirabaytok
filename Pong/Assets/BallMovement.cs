using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    void Start()
    {
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        //Skor alınmazsa top hızlanacak
    }

    void Move()
    {
        float x = Random.Range(0.5f,1.5f);
        float y = Random.Range(0.5f,1.5f);
        rb.velocity = new Vector2 (speed * x, speed * y);
        Debug.Log(speed*x);
        Debug.Log(speed*y);
    }
}
