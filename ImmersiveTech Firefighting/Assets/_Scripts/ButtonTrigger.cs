using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonTrigger : MonoBehaviour
{
    public string sceneName;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ButtonTop")
        {
            Destroy(player.gameObject);
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}
