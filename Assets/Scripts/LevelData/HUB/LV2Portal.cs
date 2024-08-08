using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LV2Portal : MonoBehaviour
{

    public GameObject fadeEffect;


    public void OnTriggerEnter(Collider c)
    {

        if (c.gameObject.name == "Player")
        {
            fadeEffect.SetActive(true);

            this.Wait(1.3f, () => { SceneManager.LoadScene(4); });
        }
    }
}
