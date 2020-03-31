using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer = 10;
    public Text timerUI;

    void Start()
    {
        
    }


    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            timerUI.text = timer.ToString("F0");
        }
        
    }

    public void EndGame()
    {

    }
}
