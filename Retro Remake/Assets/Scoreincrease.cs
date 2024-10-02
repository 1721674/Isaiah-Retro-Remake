using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreincrease : MonoBehaviour
{
    public Score score;
    public int scoreIncrease = 100;
    
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        score.currentScore += scoreIncrease;
        Destroy(gameObject);
    }    
        
}
