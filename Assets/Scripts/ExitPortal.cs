using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitPortal : MonoBehaviour
{

    public GameObject WinScreen;

    public bool LevelFinish = false;

    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider c)
    {

        if (c.gameObject.name == "Player")
        {
            LevelFinish = true;

            Time.timeScale = 0;
            WinScreen.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
