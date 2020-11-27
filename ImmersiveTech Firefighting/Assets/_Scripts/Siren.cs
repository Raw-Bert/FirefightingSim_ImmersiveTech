using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Siren : MonoBehaviour
{
    public float timer = 0.0f;

    public AudioSource sirenAudio;

    public GameObject gameManager;

    public GameObject lightRed;
    public GameObject lightBlue;
    // Start is called before the first frame update
    void Start()
    {
        //Start Audio on
    }

    // Update is called once per frame
    void Update()
    {
        if (gameManager.GetComponent<GameManager>().endGame == false)
        {
            LightChange();
        }
        
        if (gameManager.GetComponent<GameManager>().endGame == true)
        {
            //Audio off here
            //both lights off
        }
    }

    public void LightChange()
    {
        timer = timer + Time.deltaTime;
        if(timer >= 0.5)
        {
            //set red light to true and blue to false
            lightRed.SetActive(true);
            lightBlue.SetActive(false);
            
            //timeTxt.gameObject.SetActive(false);// = true;
        }
        if(timer >= 1)
        {
            //set blue light to true and red to false
            lightBlue.SetActive(true);
            lightRed.SetActive(false);
           // timeTxt.gameObject.SetActive(true);
            timer = 0;
        }
    }
}
