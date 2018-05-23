using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSystem : MonoBehaviour {
    
    public GameObject player;
    public GameObject gameMenu;
    public GameObject pauseMenu;
    public GameObject endMenu;
    public GameObject failMenu;

    // Use this for initialization
    public void MainMenu()
    {
        Application.LoadLevel("MainMenu");
    }
    public void Resume()
    {
        player.SetActive(true);
        gameMenu.SetActive(true);
        pauseMenu.SetActive(false);
        LocalTimer.StartTime();
    }
    public void Pause()
    {
        player.SetActive(false);
        LocalTimer.StopTime();
        gameMenu.SetActive(false);
        pauseMenu.SetActive(true);
    }
    public void Continue(string level)
    {
        Application.LoadLevel(level);
    }
    public void Restart(string level)
    {
        Application.LoadLevel(level);
    }
}
