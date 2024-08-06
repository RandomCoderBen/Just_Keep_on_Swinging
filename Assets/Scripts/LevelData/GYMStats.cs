using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GYMStats : MonoBehaviour
{
    public ExitPortal ExitEnd;


    public StatTracker StatTracker;


    private int score = 0;

    public TextMeshProUGUI scoreText;




    public static GYMStats instence;

    public TextMeshProUGUI TimeCounter;

    private TimeSpan timePlaying;
    private bool timerGoing;

    private float elapsedTime;


    private float FinalTime;

    public TextMeshProUGUI FinalTimeDisplay;






    private void Awake()
    {
        instence = this;
    }

    private void Start()
    {
        TimeCounter.text = "00:00";
        timerGoing = false;

        BeginTimer();

        FinalTimeDisplay.text = "00:00.00";


        //CoinStar = GameObject.FindGameObjectWithTag("Level1CoinStar");

        //CoinStar = GameObject.Find("Level1CoinStar");

    }

    void Update()
    {
        this.scoreText.text = String.Format("{0}/1", score);





        if (ExitEnd.LevelFinish == true)
        {
            EndTimer();
        }



    }


    public void UpdateScore(int increment)
    {
        this.score += increment;

        if (score == 1)   // Once all coins have been collected this code gets triggered.  && ExitEnd.LevelFinish == true
        {

        }
    }



    public void BeginTimer()
    {
        timerGoing = true;

        elapsedTime = 0f;

        StartCoroutine(UpdateTimer());
    }


    public void EndTimer()
    {
        timerGoing = false;

        FinalTime = elapsedTime;

        if (FinalTime <= 100)
        {

            //UpdateStarCount(1);

        }

        if (FinalTime < StatTracker.GYMBesttime)
        {
            StatTracker.GYMBesttime = FinalTime;
        }

    }

    private IEnumerator UpdateTimer()
    {
        while (timerGoing)
        {
            elapsedTime += Time.deltaTime;
            timePlaying = TimeSpan.FromSeconds(elapsedTime);
            string timePlayingStr = timePlaying.ToString("mm':'ss'.'ff");
            TimeCounter.text = timePlayingStr;
            FinalTimeDisplay.text = timePlayingStr;

            yield return null;
        }

    }


    public void UpdateStarCount(int increment)
    {
        StatTracker.TotalStars += increment;
    }
}
