using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGoOut : MonoBehaviour
{
    public int waterDroplets = 300;
    public ParticleSystem fireParticles;
    public ParticleSystem smokeParticles;

    public float emissionValue = 4.0f;
    public float smokEmissionValue = 10.0f;
    //public int rateOverTime;

    // Update is called once per frame
    void Update()
    {
        
    }

    //void OnCollisionEnter(Collision other)
    //{
        //Debug.Log("Not Yet");
        //if(other.gameObject.tag == "Water")
        //{
            //waterDroplets -= 1;
            //Debug.Log(waterDroplets);
            //checkFireOut();
        //}
    //}
    void OnParticleCollision(GameObject other) 
    {
        if(other.tag == "Water")
        {
            checkFireOut();
            waterDroplets -= 1;
            //checkFireOut();
            Debug.Log(waterDroplets);
            
        }
    }

    public void checkFireOut()
    {   
        
        if(waterDroplets <= 0)
        {
            Debug.Log("Gets here");
            Destroy(this.gameObject);
        }
        else if (waterDroplets <= 150)
        {
            var fireEmission = fireParticles.emission;
            fireEmission.rateOverTime = emissionValue;

            var smokeEmission = smokeParticles.emission;
            smokeEmission.rateOverTime = smokEmissionValue;
        }
    }
}
