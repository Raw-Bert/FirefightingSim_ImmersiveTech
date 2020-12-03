using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
    public GameObject explosion;
    bool hasExploded = false;
    public AudioSource boom;

    void OnTriggerEnter(Collider other)
    {
        if (hasExploded == false)
        {
            if (other.tag == "Door")
            {
                explosion.SetActive(true);
                boom.Play();
                hasExploded = true;
            }
        }
    }
}
