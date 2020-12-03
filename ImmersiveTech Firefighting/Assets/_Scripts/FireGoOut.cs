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
    public bool isOut;

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnParticleCollision(GameObject other) 
    {
        if(other.tag == "Water")
        {
            checkFireOut();
            waterDroplets -= 1;
        }
    }

    public void checkFireOut()
    {   
        
        if(waterDroplets <= 0)
        {
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
