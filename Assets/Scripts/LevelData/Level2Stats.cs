using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.XR;
using UnityEngine.SceneManagement;


public class Level2Stats : MonoBehaviour
{


    public ExitPortal ExitEnd;


    public StatTracker StatTracker;


    private int score = 0;

    public TextMeshProUGUI scoreText;




    public static Level2Stats instence;

    public TextMeshProUGUI TimeCounter;

    private TimeSpan timePlaying;
    private bool timerGoing;

    private float elapsedTime;


    private float FinalTime;

    public TextMeshProUGUI FinalTimeDisplay;

    public TextMeshProUGUI BestTime;




    public GameObject TimeStar;

    public GameObject CoinStar;

    public GameObject ChallangeStar;


    private void Awake()
    {
        instence = this;
    }

    private void Start()
    {
        TimeCounter.text = "00:00";
        timerGoing = false;

        this.Wait(1f, () => { BeginTimer(); });

        FinalTimeDisplay.text = "00:00.00";

        this.BestTime.text = String.Format("{00:00.00}", StatTracker.LV2Besttime);


        //CoinStar = GameObject.FindGameObjectWithTag("Level1CoinStar");

        //CoinStar = GameObject.Find("Level1CoinStar");

    }

    void Update()
    {
        this.scoreText.text = String.Format("{0}/1", score);



        if (StatTracker.LV2TimeWin == true)
        {
            TimeStar.SetActive(true);
        }
        else
        {
            TimeStar.SetActive(false);
        }

        if (StatTracker.LV2CoinWin == true)
        {
            CoinStar.SetActive(true);
        }
        else
        {
            CoinStar.SetActive(false);
        }

        if (StatTracker.LV2ChallangeWin == true)
        {
            ChallangeStar.SetActive(true);
        }
        else
        {
            ChallangeStar.SetActive(false);
        }



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
            StatTracker.LV2CoinWin = true;

            //UpdateStarCount(1);
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
            StatTracker.LV2TimeWin = true;

            //UpdateStarCount(1);

        }

        if (FinalTime < StatTracker.LV2Besttime)
        {
            StatTracker.LV2Besttime = FinalTime;
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