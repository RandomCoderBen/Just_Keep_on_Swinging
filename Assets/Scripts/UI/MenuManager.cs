using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject WinScreen;
    public GameObject pauseMenu;
    public GameObject gameOverMenu;

    public GameObject fadeEffect;

    void Start()
    {
        //Timer.instence.BeginTimer();  // Activates Timer code upon level start.

        WinScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
void ShowWin()
{
    WinScreen.SetActive(true);
}

 

    public void Restart()
    {
        SceneManager.LoadScene(Application.loadedLevel);  // Code set to the side to be acessed by the pause menu button to reload the level.
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Hub()
    {
        fadeEffect.SetActive(true);

        this.Wait(1.3f, () => { SceneManager.LoadScene(1); });
    }

    public void Level1()
    {
        SceneManager.LoadScene(2);
    }

    public void Level2()
    {
        SceneManager.LoadScene(3);
    }

    public void Exit()
    {
        Application.Quit();
    }


    public void StartMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void GameOverMenu()
    {
        gameOverMenu.SetActive(true);
        pauseMenu.SetActive(false);
        WinScreen.SetActive(false);
        Time.timeScale = 0;
        //SoundsManager.Instance.PlayGameOverMusic();
    }


}
