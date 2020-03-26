using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public int score;
    private string textToDisplay;
    public Text scoreText;
    private Lives playerLives;
    private bool canLifeUp;
    // Start is called before the first frame update
    void Start()
    {
        playerLives = gameObject.GetComponent<Lives>();
    }

    // Update is called once per frame
    void Update()
    {
        textToDisplay = "Score : " + score.ToString();

        scoreText.text = textToDisplay;

        if (score % 1000 == 0 && canLifeUp && score!=0)
        {
            playerLives.LifeUp();
            canLifeUp = false;
        }
        else if (score % 1000 !=0)
            canLifeUp = true;
    }

    public void ScoreUp(int value)
    {
        score += value;
    }
}
