using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour {

    public GameObject mainMenu;
    public GameObject levelsMenu;

	// Use this for initialization
	public void Play()
    {
        mainMenu.SetActive(false);
        levelsMenu.SetActive(true);
    }

    public void Back()
    {
        mainMenu.SetActive(true);
        levelsMenu.SetActive(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void LaunchLevel(string name)
    {
        Application.LoadLevel(name);
    }
}
