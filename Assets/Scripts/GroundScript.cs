using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GroundScript : MonoBehaviour {

    public GameObject timer;
    public GameObject endMenu;
    public GameObject gameMenu;
    void Update()
    {
        int allTime = timer.GetComponent<LocalTimer>().timeForLevel * 100;
        float timePassed = LocalTimer.fixedTime() * 100f;
        int score = allTime - (int)timePassed;

        if (score < 0)
        {
            GameObject.Find("Player").gameObject.SetActive(false);
            LocalTimer.StopTime();
            endMenu.SetActive(true);
            gameMenu.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            LocalTimer.StopTime();
            endMenu.SetActive(true);
            gameMenu.SetActive(false);
        }
    }
}
