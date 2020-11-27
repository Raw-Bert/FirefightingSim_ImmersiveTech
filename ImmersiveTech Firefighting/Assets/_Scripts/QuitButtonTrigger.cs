using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitButtonTrigger : MonoBehaviour
{    
    void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "QuitButtonTop"){
            Application.Quit();
            Debug.Log("WAT");
        }
    }
}
