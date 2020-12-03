using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float timer = 0.0f;
    public float seconds;
    public float minutes;
    public float hours;

    public List<GameObject> allFires = new List<GameObject>();

    public TextMeshProUGUI timeTxt;
    public TextMeshProUGUI finalTxt;

    public GameObject nozzle;

    public Vector3 nozzlePos = new Vector3(0,2,0);

    public bool endGame = false;

    public GameObject extraction;
    public GameObject iintSmoke;

    void Start(){
        finalTxt.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (!endGame)
        {
            CountSeconds();
            CheckWin();
        }
        if(endGame == true)
        {   
            finalTxt.gameObject.SetActive(true);
            Winner();
        }
        
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
        for (int i = 0; i < allFires.Count; i++)
        {
            if (allFires[i] == null)
            {
                if (i == (allFires.Count -1))
                {
                    if(extraction.GetComponent<Extract>().extrct == true)
                    {
                        timer = 0;
                        endGame = true;
                        iintSmoke.SetActive(false);
                    }

                }
            }
            else if (allFires[i] != null)
            {
                break;
            }
        }

        if(allFires.Count == 0)
        {
            Debug.Log("Win");
        }
        if(allFires.Count == 4)
        {
            Debug.Log("notWin");
        }
    }

    public void Winner()
    {
        TimerFlash();
    }

    public void TimerFlash()
    {
        //exit();
        timer = timer + Time.deltaTime;
        if(timer >= 0.5)
        {
            timeTxt.gameObject.SetActive(false);// = true;
        }
        if(timer >= 1)
        {
            timeTxt.gameObject.SetActive(true);
            timer = 0;
        }
    }

}
