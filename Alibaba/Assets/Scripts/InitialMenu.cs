using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitialMenu : MonoBehaviour
{
    private void Start()
    {
        PlayerPrefs.SetInt("GemScore", 0);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;//Evitar la pausa
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void StartGameMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit() 
    {
        Debug.Log("Salir");
        Application.Quit();
    }

}


