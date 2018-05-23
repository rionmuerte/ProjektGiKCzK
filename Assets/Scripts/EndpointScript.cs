using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndpointScript : MonoBehaviour {

    public GameObject timer;
    public GameObject endMenu;
    public GameObject gameMenu;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.SetActive(false);
            LocalTimer.StopTime();
            int allTime = timer.GetComponent<LocalTimer>().timeForLevel * 100;
            float timePassed = LocalTimer.fixedTime() * 100f;
            int score = allTime - (int)timePassed;
            endMenu.SetActive(true);
            gameMenu.SetActive(false);
            var text = endMenu.transform.Find("EndScoreText").gameObject;
            if (text != null)
            {
                text.GetComponent<Text>().text = "Score: " + score.ToString();
            }
        }
    }
}
