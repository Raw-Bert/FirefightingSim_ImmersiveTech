using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterShoot : MonoBehaviour
{
    public ParticleSystem water;
    // Start is called before the first frame update
    void Start()
    {
        water.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        //water.Stop();
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
            water.Stop();
        }
    }
}
