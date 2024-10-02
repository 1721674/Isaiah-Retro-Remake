using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public int currentScore;
    public TMPro.TMP_Text scoreText;
    public string message = "Score: ";
    

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText(message + currentScore.ToString());
    }
}
