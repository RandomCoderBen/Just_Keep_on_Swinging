using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    //public GameObject Instructions;
    //public GameObject LevelSelect;
    public GameObject canvas;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        canvas.SetActive(true);
        //Instructions.SetActive(false);
        //LevelSelect.SetActive(false);
    }


    //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    public void StartLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void StartLevel2()
    {
        SceneManager.LoadScene(2);
    }
    public void StartLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void HowToPlay()
    { 
        //Instructions.SetActive(true); 
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void HowToclose()
    {
        //Instructions.SetActive(false);
    }


    public void SelectLevel()
    {
        //LevelSelect.SetActive(true);
    }

    public void SelectLevelClose()
    {
        //LevelSelect.SetActive(false);
    }

}
