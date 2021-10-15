using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class BallMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    private bool ballmoving = false;
    public int aiscore, playerscore;
    private TextMeshProUGUI aiscoretmp, playerscoretmp;
    

   void Start()
    {
        Invoke("Move", 2); 
        aiscoretmp = GameObject.Find("AI Score").GetComponent<TextMeshProUGUI>();
        playerscoretmp = GameObject.Find("Player Score").GetComponent<TextMeshProUGUI>();  
        Invoke("GoFaster", 10);
        Invoke("GoFaster", 20);
    }
    
    void Update()
    {
        //Top hareket ediyorsa ve x ya da y eksenindeki hızı çok yavaşsa tekrar hız ver
        if(ballmoving)
        {
            if(Mathf.Abs(rb.velocity.y) < 2.5f || Mathf.Abs(rb.velocity.x) < 2.5f)
            {
            Move();
            }

        }      
    }

    void Move()
    {
        ballmoving = true;
        float x = Random.Range(0,2) == 0 ? -1 : 1;
        float y = Random.Range(0,2) == 0 ? -1 : 1;
        rb.velocity = new Vector2 (speed * x, speed * y);
    }

    void GoFaster()
    {
        rb.velocity = rb.velocity * 1.3f;
    }

    private void OnTriggerEnter2D (Collider2D other)
    {
        if(other.gameObject.name == "AI Goal")
        {
            IncreasePlayerScore();
        }
        else if(other.gameObject.name == "Player Goal")
        {
            IncreaseAIScore();
        }
    } 

    void IncreaseAIScore()
    {
        int currentScore = int.Parse(aiscoretmp.text);
        aiscoretmp.text = (currentScore + 1).ToString();
        GameObject.Find("BallManager").GetComponent<BallManager>().DestroyBall();
    }
    

    void IncreasePlayerScore()
    {
        int currentScore = int.Parse(playerscoretmp.text);
        playerscoretmp.text = (currentScore + 1).ToString();
        GameObject.Find("BallManager").GetComponent<BallManager>().DestroyBall();
    }
    


}
