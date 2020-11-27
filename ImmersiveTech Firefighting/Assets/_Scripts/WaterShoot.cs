using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterShoot : MonoBehaviour
{
    public ParticleSystem water;
    public AudioSource waterAudio;


    // Start is called before the first frame update
    void Start()
    {
        waterAudio.Stop();
        water.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            waterAudio.Play();
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            Debug.Log("Hand");
            water.Play();

        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Hand")
        {
            Debug.Log("No Hand");
            waterAudio.Stop();
            water.Stop();

        }
    }
}
