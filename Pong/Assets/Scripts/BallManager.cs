using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public GameObject ballPrefab;
    private GameObject currentBall;
   
   void Update()
   {
       if(GameObject.FindGameObjectWithTag("Ball") != null)
       {
           currentBall = GameObject.FindGameObjectWithTag("Ball");
       }
   }
   public void DestroyBall()
    {
        Destroy(currentBall);
        Instantiate(ballPrefab, transform.position, Quaternion.identity);
    }
}
