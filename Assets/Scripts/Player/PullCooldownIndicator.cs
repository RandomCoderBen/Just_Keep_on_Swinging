using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullCooldownIndicator : MonoBehaviour
{

    public GameObject CooldownIndicator;

    public Material PullNotReady;

    public Material PullReady;


    public PullHook Pull;


    void Update()
    {
     if  (Pull.PullCooldownTimer > 0)
        {
            CooldownIndicator.GetComponent<MeshRenderer>().material = PullNotReady;
        }
     else
        {
            CooldownIndicator.GetComponent<MeshRenderer>().material = PullReady;
        }
    }
}
