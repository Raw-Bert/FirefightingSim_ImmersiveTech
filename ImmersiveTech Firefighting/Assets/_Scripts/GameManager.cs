using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Menu, with buttons
//Timer
//Water particle put out fire, also shoots when player pcisk up hose nozzle
//Game win when put out all fire, time shown?


public class GameManager : MonoBehaviour
{
    public float timer = 0.0f;
    public int seconds;

    // Update is called once per frame
    void Update()
    {
        CountSeconds();
    }
    
    public void CountSeconds()
    {
        timer += Time.deltaTime;
        seconds = (int)(timer % 60);
        Debug.Log(seconds);
    }
}
