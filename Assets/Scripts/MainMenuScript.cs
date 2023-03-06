using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{

    public GameObject panelSeru;

    public void Cover()
    {
        SceneManager.LoadScene("Cover");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void DrawingPertama()
    {
        SceneManager.LoadScene("DrawingPertama");
    }

    public void ShowObject()
    {
        SceneManager.LoadScene("ShowObject");
    }
    
    public void Building()
    {
        SceneManager.LoadScene("Building");
    }

    public void BackToHome()
    {
        SceneManager.LoadScene("Home");
    }

    public void BackToGeometri()
    {
        SceneManager.LoadScene("Geometri");
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    public void TandaSeru()
    {
        if (Time.timeScale == 1)
        {
            panelSeru.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
            panelSeru.SetActive(false); 
        }
    }
}
