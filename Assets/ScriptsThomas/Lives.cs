using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Lives : MonoBehaviour
{
    public int lives = 3;
    public string textToDisplay;
    public Text text;
    

    // Update is called once per frame
    void Update()
    {
        if (lives > 99)
            textToDisplay = "Lives : 99+";

        else
            textToDisplay ="Lives : " + lives.ToString();

        text.text = textToDisplay;

        if (lives <= 0)
            Destroy(gameObject);
            GameOver();
    }

    public void LifeUp()
    {
        lives++;
    }

    public void LifeDown()
    {
        lives--;
    }

    public void GameOver()
    {
        //le game over wlh
    }
}
