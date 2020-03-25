using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score;
    private string textToDisplay;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        textToDisplay = "Score : " + score.ToString();

        scoreText.text = textToDisplay;
    }

    public void ScoreUp(int value)
    {
        score += value;
    }
}
