using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class StatDisplay : MonoBehaviour
{

    public static StatDisplay instence;


    public StatTracker StatTracker;

    private float HideTime = 1000;

    private TimeSpan timePlaying;



    public TextMeshProUGUI GYMTime;

    public GameObject GYMTimeDisplay;



    public TextMeshProUGUI LV1Time;

    public GameObject LV1TimeDisplay;

    public GameObject LV1TimeStar;

    public GameObject LV1CoinStar;

    public GameObject LV1ChallangeStar;




    public TextMeshProUGUI LV2Time;

    public GameObject LV2TimeDisplay;

    public GameObject LV2TimeStar;

    public GameObject LV2CoinStar;

    public GameObject LV2ChallangeStar;

    // Start is called before the first frame update
    void Start()
    {
        this.GYMTime.text = String.Format("{00:00.00}", StatTracker.GYMBesttime);

        this.LV1Time.text = String.Format("{00:00.00}", StatTracker.LV1Besttime);

        this.LV2Time.text = String.Format("{00:00.00}", StatTracker.LV2Besttime);


        CheckGYMStats();

        CheckLV1Stats();

        CheckLV2Stats();


        //UpdateTimers();
    }


     void Awake()
    {
        instence = this;
    }


    // Update is called once per frame
    void Update()
    {

    }


    public void CheckGYMStats()
    {
        if (StatTracker.GYMBesttime <= HideTime)
        {
            GYMTimeDisplay.SetActive(true);
        }
        else
        {
            GYMTimeDisplay.SetActive(false);
        }
    }


    public void CheckLV1Stats()
    {
        if (StatTracker.LV1TimeWin == true)
        {
            LV1TimeStar.SetActive(true);
        }
        else
        {
            LV1TimeStar.SetActive(false);
        }


        if (StatTracker.LV1CoinWin == true)
        {
            LV1CoinStar.SetActive(true);
        }
        else
        {
            LV1CoinStar.SetActive(false);
        }


        if (StatTracker.LV1ChallangeWin == true)
        {
            LV1ChallangeStar.SetActive(true);
        }
        else
        {
            LV1ChallangeStar.SetActive(false);
        }


        if (StatTracker.LV1Besttime <= HideTime)
        {
            LV1TimeDisplay.SetActive(true);
        }
        else
        {
            LV1TimeDisplay.SetActive(false);
        }
    }



    public void CheckLV2Stats()
    {
        if (StatTracker.LV2TimeWin == true)
        {
            LV2TimeStar.SetActive(true);
        }
        else
        {
            LV2TimeStar.SetActive(false);
        }


        if (StatTracker.LV2CoinWin == true)
        {
            LV2CoinStar.SetActive(true);
        }
        else
        {
            LV2CoinStar.SetActive(false);
        }


        if (StatTracker.LV2ChallangeWin == true)
        {
            LV2ChallangeStar.SetActive(true);
        }
        else
        {
            LV2ChallangeStar.SetActive(false);
        }


        if (StatTracker.LV2Besttime < HideTime)
        {
            LV2TimeDisplay.SetActive(true);
        }
        else
        {
            LV2TimeDisplay.SetActive(false);
        }
    }

}
