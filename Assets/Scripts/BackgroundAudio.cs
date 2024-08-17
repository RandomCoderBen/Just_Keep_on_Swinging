using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundAudio : MonoBehaviour
{

    [SerializeField]
    AudioSource backgroundAudio;

    


    public void OnTriggerEnter(Collider c)
    {

        if (c.gameObject.name == "Player")  // Detects if the Player is entering the trigger
        {
            backgroundAudio.Play();
        }

    }


    public void OnTriggerExit(Collider c)
    {

        if (c.gameObject.name == "Player")  // Detects if the Player has left the trigger
        {
            backgroundAudio.Stop();
        }

    }
    
}
