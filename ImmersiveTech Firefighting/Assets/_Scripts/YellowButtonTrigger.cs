using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.SceneManagement;


public class YellowButtonTrigger : MonoBehaviour
{
    //public string sceneName;
    //public GameObject player;
    public AudioSource click;
    //public GameObject tele;
    
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("WTFLESS");
        if (other.tag == "ButtonTop")
        {
            //Debug.Log("WTF");
            click.Play();
            //Destroy(tele.gameObject);
            //Destroy(player.gameObject);
            //SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}
