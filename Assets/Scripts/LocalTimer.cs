using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalTimer : MonoBehaviour {

    public int timeForLevel;
    public Text timeLevelDisplay;
    private int timeLeft;
    private static float localTime;
    private static bool isRunning;
    private static float deltaTime;

    public static float deltaT()
    {
        return deltaTime;
    }
    public static float fixedTime()
    {
        return localTime;
    }
    // Use this for initialization
    void Start() {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        localTime = 0f;
        isRunning = true;
        timeLevelDisplay.text = "Time left: " + timeForLevel.ToString();
    }

    // Update is called once per frame
    void Update() {
        if (isRunning)
        {
            deltaTime = Time.deltaTime;
            localTime += deltaTime;
            timeLeft = timeForLevel - (int)localTime;
        }
        timeLevelDisplay.text = "Time left: " + timeLeft.ToString();
    }

    public static void StartTime()
    {
        isRunning = true;
    }
    
    public static void StopTime()
    {
        isRunning = false;
    }
        
}
