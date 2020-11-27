using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


//Menu, with buttons
//Game win when put out all fire
//Time at end of game.
//make water sound start/stop
//Blinking lights on firetruck + siren sound

public class GameManager : MonoBehaviour
{
    public float timer = 0.0f;
    public float seconds;
    public float minutes;
    public float hours;

    public List<GameObject> allFires = new List<GameObject>();

    public TextMeshProUGUI timeTxt;

    public GameObject nozzle;

    public Vector3 nozzlePos = new Vector3(0,2,0);
    // Update is called once per frame
    void Update()
    {
        CountSeconds();
        CheckWin();
        
        float pos = nozzle.transform.position.y;
        if(pos > 100 || pos < -10)
        {
            nozzle.transform.position = nozzlePos;
        }
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
        
        timeTxt.text = (hours + " : " + minutes + " : " + seconds);
    }

    public void CheckWin()
    {
        if(allFires.Count == 0)
        {
            Debug.Log("Win");
        }
        if(allFires.Count == 4)
        {
            Debug.Log("notWin");
        }
    }
}
