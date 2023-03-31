using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class UiManager : MonoBehaviour
{
    public GameObject gameoverpanel;
    public PlayerController playercontroller;
   
    private void Update()
    {
        if(playercontroller.currenthealth == 0)
        {
            gameoverpanel.SetActive(true);
        }
    }

    public void startgame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Gameplay");
    }
     public void quitgame()
    {
        Application.Quit();
    }
}
