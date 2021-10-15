using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
        public bool aigoal;
        public TextMeshProUGUI aiscoretmp, playerscoretmp;
        public int aiscore, playerscore;


    void Start()
    {

    }

    void Update()
    {
        
    }

    public void IncreaseAIScore()
    {
        int currentScore = int.Parse(aiscoretmp.text);
        aiscoretmp.text = (currentScore + 1).ToString();
    }
    

    public void IncreasePlayerScore()
    {
        int currentScore = int.Parse(playerscoretmp.text);
        playerscoretmp.text = (currentScore + 1).ToString();
    }

}
