using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintDisplay : MonoBehaviour {

    public string hintsText;

    public Text textBox;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            textBox.text = hintsText;
        }
    }
    void OnTriggerExit(Collider other)
    {
        textBox.text = "";
        gameObject.SetActive(false);
    }
}
