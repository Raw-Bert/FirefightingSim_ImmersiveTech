using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonTrigger : MonoBehaviour
{    
    public AudioSource click;
    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "QuitButtonTop"){
            click.Play();
            Application.Quit();
            Debug.Log("WAT");
        }
    }
}
