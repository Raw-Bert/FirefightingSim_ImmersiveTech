using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTrigger : MonoBehaviour
{
    public string sceneName;
    public GameObject player;
    public AudioSource click;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ButtonTop")
        {
            click.Play();
            Destroy(player.gameObject);
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}
