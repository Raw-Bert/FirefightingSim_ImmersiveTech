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
    public float seconds;
    public float minutes;
    public float hours;

    // Update is called once per frame
    void Update()
    {
        CountSeconds();
    }
    
    public void CountSeconds()
    {
        timer += Time.deltaTime;
        


        if(timer > 60)
        {
            minutes += 1;
            timer = 0;
        }
        if(minutes > 60)
        {
            hours += 1;
            minutes = 0;
        }
        seconds = (int)(timer % 60);
        minutes = (int)(minutes % 60);
        hours = (int)(hours % 60);
        
        Debug.Log(hours + " : " + minutes + " : " + seconds);
    }
}
