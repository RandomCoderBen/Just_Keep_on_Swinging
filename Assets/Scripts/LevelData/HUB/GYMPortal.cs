using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GYMPortal : MonoBehaviour
{
    public void OnTriggerEnter(Collider c)
    {

        if (c.gameObject.name == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
