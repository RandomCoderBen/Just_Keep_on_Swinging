using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR;


[CreateAssetMenu]
public class StatTracker : ScriptableObject
{

    public int TotalStars = 0;



    public float GYMBesttime = 1000;



    public float LV1Besttime = 1000;


    public bool LV1TimeWin = false;

    public bool LV1CoinWin = false;

    public bool LV1ChallangeWin = false;



    public float LV2Besttime = 1000;

    public bool LV2TimeWin = false;

    public bool LV2CoinWin = false;

    public bool LV2ChallangeWin = false;



    public float LV3Besttime = 1000;

    public bool LV3TimeWin = false;

    public bool LV3CoinWin = false;

    public bool LV3ChallangeWin = false;

}
