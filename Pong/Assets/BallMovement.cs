using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private bool ballmoving = false;
    
   void Start()
    {
        Invoke("Move",2);
    }

    void Update()
    {
        //Top hareket ediyorsa ve x ya da y eksenindeki hızı çok yavaşsa tekrar hız ver
        if(ballmoving)
        {
            if(Mathf.Abs(rb.velocity.y) < 1.5f || Mathf.Abs(rb.velocity.x) < 1.5f)
            {
            Move();
            }

        }      
        //Skor alınmazsa top hızlanacak
        //rb.velocity = rb.velocity * 1.3f;
    }

    void Move()
    {
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2 (speed * x, speed * y);
    }

    private void OnTriggerEnter (Collider other)
    {
        if(other.GetComponent<ScoreManager>().aigoal == true)
        {
            other.GetComponent<ScoreManager>().IncreasePlayerScore();
        }
        if(other.GetComponent<ScoreManager>().aigoal != true)
        {
            other.GetComponent<ScoreManager>().IncreaseAIScore();
        }
    } 
}
