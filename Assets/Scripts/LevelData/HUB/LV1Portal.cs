using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LV1Portal : MonoBehaviour
{


    public void OnTriggerEnter(Collider c)
    {

        if (c.gameObject.name == "Player")
        {
            SceneManager.LoadScene(3);
        }
    }
}
