using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour

{ // all serialized and public variables 
    [SerializeField] int TimeSet;
    [SerializeField] TMP_Text scoretext;
    [SerializeField] TMP_Text timerText;
    public int score;
    public int timer;
    // Start is called before the first frame update
    void Start()
    {
        score = 0; // creates a score variable 
    }

            // Update is called once per frame
    void Update()
            {

        timer = (TimeSet - (int)Time.time); // gets the time that is passing and subtracts it from the timeset on the serialized feild in front end 
        timerText.text = timer.ToString(); // gets the text and changes it to a string
        scoretext.text = score.ToString(); // changes the text to a string
       if (timer == 0) // if statement for when the timer = 0
        {
           timerText.text = "Game Over"; // shows a game over text when the timer reaches 0
            Time.timeScale = 0; // ends the game when the timer reaches 0
        }
            }
        }
    

